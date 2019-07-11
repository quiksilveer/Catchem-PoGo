﻿#region using directives

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using PoGo.PokeMobBot.Logic.Event.Item;
using PoGo.PokeMobBot.Logic.Event.Pokemon;
using PoGo.PokeMobBot.Logic.PoGoUtils;
using PoGo.PokeMobBot.Logic.State;
using PoGo.PokeMobBot.Logic.Utils;
using PokemonGo.RocketAPI.Extensions;
using POGOProtos.Inventory.Item;

#endregion

namespace PoGo.PokeMobBot.Logic.Tasks
{
    public class EvolvePokemonTask
    {

        public static async Task Execute(ISession session, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (!await CheckBotStateTask.Execute(session, cancellationToken)) return;
            var prevState = session.State;
            session.State = BotState.Evolve;
            // Refresh inventory so that the player stats are fresh
            await session.Inventory.RefreshCachedInventory();

            var pokemonToEvolveTask = await session.Inventory.GetPokemonToEvolve(session.LogicSettings, session.LogicSettings.PokemonsToEvolve);
            var pokemonToEvolve = pokemonToEvolveTask.Where(x => string.IsNullOrEmpty(x.DeployedFortId)).ToList();

            if (pokemonToEvolve.Any())
            {
                var inventoryContent = await session.Inventory.GetItems();

                var luckyEggs = inventoryContent.Where(p => p.ItemId == ItemId.ItemLuckyEgg);
                var luckyEgg = luckyEggs.FirstOrDefault();
                var usedItems = await session.Inventory.GetUsedItems();
                var eggUsed = usedItems?.Any(x => x.ItemId == ItemId.ItemLuckyEgg && x.ExpireMs > DateTime.UtcNow.ToUnixTime()) ?? false;

                //maybe there can be a warning message as an else condition of luckyEgg checks, like; 
                //"There is no Lucky Egg, so, your UseLuckyEggsMinPokemonAmount setting bypassed."
                if (session.LogicSettings.UseLuckyEggsWhileEvolving && luckyEgg != null && luckyEgg.Count > 0 && !eggUsed)
                {
                    if (pokemonToEvolve.Count >= session.LogicSettings.UseLuckyEggsMinPokemonAmount)
                    {
                        await UseLuckyEgg(session);
                        session.State = BotState.LuckyEgg;
                    }
                    else
                    {
                        // Wait until we have enough pokemon
                        session.EventDispatcher.Send(new UseLuckyEggMinPokemonEvent
                        {
                            Diff = session.LogicSettings.UseLuckyEggsMinPokemonAmount - pokemonToEvolve.Count,
                            CurrCount = pokemonToEvolve.Count,
                            MinPokemon = session.LogicSettings.UseLuckyEggsMinPokemonAmount
                        });
                        session.State = prevState;
                        return;
                    }
                }
                var pokemonFamilies = session.Inventory.GetPokemonFamilies().Result;
                foreach (var pokemon in pokemonToEvolve)
                {
                    // no cancellationToken.ThrowIfCancellationRequested here, otherwise the lucky egg would be wasted.
                    var evolveResponse = await session.Client.Inventory.EvolvePokemon(pokemon.Id);

                    session.EventDispatcher.Send(new PokemonEvolveEvent
                    {
                        Uid = pokemon.Id,
                        Id = pokemon.PokemonId,
                        Exp = evolveResponse.ExperienceAwarded,
                        Result = evolveResponse.Result
                    });

                    if (evolveResponse.EvolvedPokemonData != null)
                    {
                        var pokemonSettings = session.Inventory.GetPokemonSettings().Result.ToList();
                        var setting = pokemonSettings.Single(q => q.PokemonId == evolveResponse.EvolvedPokemonData.PokemonId);
                        var family = pokemonFamilies.First(q => q.FamilyId == setting.FamilyId);
                        session.EventDispatcher.Send(new PokemonEvolveDoneEvent
                        {
                            Uid = evolveResponse.EvolvedPokemonData.Id,
                            Id = evolveResponse.EvolvedPokemonData.PokemonId,
                            Cp = evolveResponse.EvolvedPokemonData.Cp,
                            Perfection = evolveResponse.EvolvedPokemonData.CalculatePokemonPerfection(),
                            Family = family.FamilyId,
                            Candy = family.Candy_,
                            Level = pokemon.GetLevel(),
                            Move1 = evolveResponse.EvolvedPokemonData.Move1,
                            Move2 = evolveResponse.EvolvedPokemonData.Move2,
                            Type1 = setting.Type,
                            Type2 = setting.Type2,
                            Stats = setting.Stats,
                            MaxCp = (int)PokemonInfo.GetMaxCpAtTrainerLevel(pokemon, session.Runtime.CurrentLevel),
                            Stamina = pokemon.Stamina,
                            IvSta = pokemon.IndividualStamina,
                            PossibleCp = (int)PokemonInfo.GetMaxCpAtTrainerLevel(pokemon, 40),
                            CandyToEvolve = setting.CandyToEvolve,
                            IvAtk = pokemon.IndividualAttack,
                            IvDef = pokemon.IndividualDefense,
                            Weight = pokemon.WeightKg,
                            Cpm = pokemon.CpMultiplier,
                            StaminaMax = pokemon.StaminaMax,
                            Evolutions = setting.EvolutionIds.ToArray()
                        });
                    }
                    await DelayingEvolveUtils.Delay(session.LogicSettings.DelayEvolvePokemon, 0, session.LogicSettings.DelayEvolveVariation, cancellationToken);
                }
            }
            session.State = prevState;
        }

        public static async Task UseLuckyEgg(ISession session)
        {
            var inventoryContent = await session.Inventory.GetItems();

            var luckyEggs = inventoryContent.Where(p => p.ItemId == ItemId.ItemLuckyEgg);
            var luckyEgg = luckyEggs.FirstOrDefault();
            await session.Client.Inventory.UseItemXpBoost();

            session.EventDispatcher.Send(new ItemLostEvent
            {
                Id = ItemId.ItemLuckyEgg,
                Count = 1
            });
            session.EventDispatcher.Send(new ItemUsedEvent
            {
                Id = ItemId.ItemLuckyEgg,
                ExpireMs = DateTime.UtcNow.AddMinutes(30).ToUnixTime()
            });

            await session.Inventory.RefreshCachedInventory();
            if (luckyEgg != null) session.EventDispatcher.Send(new UseLuckyEggEvent {Count = luckyEgg.Count});
                await Task.Delay(session.LogicSettings.DelayDisplayPokemon);
        }
    }
}
