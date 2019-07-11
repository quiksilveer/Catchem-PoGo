// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Map/Fort/FortData.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Map.Fort {

  /// <summary>Holder for reflection information generated from POGOProtos/Map/Fort/FortData.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class FortDataReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Map/Fort/FortData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FortDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnREYXRhLnByb3RvEhNQT0dPUHJv",
            "dG9zLk1hcC5Gb3J0GiBQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25JZC5wcm90",
            "bxogUE9HT1Byb3Rvcy9FbnVtcy9UZWFtQ29sb3IucHJvdG8aJlBPR09Qcm90",
            "b3MvSW52ZW50b3J5L0l0ZW0vSXRlbUlkLnByb3RvGiJQT0dPUHJvdG9zL01h",
            "cC9Gb3J0L0ZvcnRUeXBlLnByb3RvGiVQT0dPUHJvdG9zL01hcC9Gb3J0L0Zv",
            "cnRTcG9uc29yLnByb3RvGitQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnRSZW5k",
            "ZXJpbmdUeXBlLnByb3RvGiZQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnRMdXJl",
            "SW5mby5wcm90byL9BAoIRm9ydERhdGESCgoCaWQYASABKAkSIgoabGFzdF9t",
            "b2RpZmllZF90aW1lc3RhbXBfbXMYAiABKAMSEAoIbGF0aXR1ZGUYAyABKAES",
            "EQoJbG9uZ2l0dWRlGAQgASgBEjIKDW93bmVkX2J5X3RlYW0YBSABKA4yGy5Q",
            "T0dPUHJvdG9zLkVudW1zLlRlYW1Db2xvchI1ChBndWFyZF9wb2tlbW9uX2lk",
            "GAYgASgOMhsuUE9HT1Byb3Rvcy5FbnVtcy5Qb2tlbW9uSWQSGAoQZ3VhcmRf",
            "cG9rZW1vbl9jcBgHIAEoBRIPCgdlbmFibGVkGAggASgIEisKBHR5cGUYCSAB",
            "KA4yHS5QT0dPUHJvdG9zLk1hcC5Gb3J0LkZvcnRUeXBlEhIKCmd5bV9wb2lu",
            "dHMYCiABKAMSFAoMaXNfaW5fYmF0dGxlGAsgASgIEj8KFGFjdGl2ZV9mb3J0",
            "X21vZGlmaWVyGAwgAygOMiEuUE9HT1Byb3Rvcy5JbnZlbnRvcnkuSXRlbS5J",
            "dGVtSWQSNAoJbHVyZV9pbmZvGA0gASgLMiEuUE9HT1Byb3Rvcy5NYXAuRm9y",
            "dC5Gb3J0THVyZUluZm8SJgoeY29vbGRvd25fY29tcGxldGVfdGltZXN0YW1w",
            "X21zGA4gASgDEjEKB3Nwb25zb3IYDyABKA4yIC5QT0dPUHJvdG9zLk1hcC5G",
            "b3J0LkZvcnRTcG9uc29yEj4KDnJlbmRlcmluZ190eXBlGBAgASgOMiYuUE9H",
            "T1Byb3Rvcy5NYXAuRm9ydC5Gb3J0UmVuZGVyaW5nVHlwZRIdChVkZXBsb3lf",
            "bG9ja291dF9lbmRfbXMYESABKANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.PokemonIdReflection.Descriptor, global::POGOProtos.Enums.TeamColorReflection.Descriptor, global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, global::POGOProtos.Map.Fort.FortTypeReflection.Descriptor, global::POGOProtos.Map.Fort.FortSponsorReflection.Descriptor, global::POGOProtos.Map.Fort.FortRenderingTypeReflection.Descriptor, global::POGOProtos.Map.Fort.FortLureInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Map.Fort.FortData), global::POGOProtos.Map.Fort.FortData.Parser, new[]{ "Id", "LastModifiedTimestampMs", "Latitude", "Longitude", "OwnedByTeam", "GuardPokemonId", "GuardPokemonCp", "Enabled", "Type", "GymPoints", "IsInBattle", "ActiveFortModifier", "LureInfo", "CooldownCompleteTimestampMs", "Sponsor", "RenderingType", "DeployLockoutEndMs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class FortData : pb::IMessage<FortData> {
    private static readonly pb::MessageParser<FortData> _parser = new pb::MessageParser<FortData>(() => new FortData());
    public static pb::MessageParser<FortData> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Map.Fort.FortDataReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public FortData() {
      OnConstruction();
    }

    partial void OnConstruction();

    public FortData(FortData other) : this() {
      id_ = other.id_;
      lastModifiedTimestampMs_ = other.lastModifiedTimestampMs_;
      latitude_ = other.latitude_;
      longitude_ = other.longitude_;
      ownedByTeam_ = other.ownedByTeam_;
      guardPokemonId_ = other.guardPokemonId_;
      guardPokemonCp_ = other.guardPokemonCp_;
      enabled_ = other.enabled_;
      type_ = other.type_;
      gymPoints_ = other.gymPoints_;
      isInBattle_ = other.isInBattle_;
      activeFortModifier_ = other.activeFortModifier_.Clone();
      LureInfo = other.lureInfo_ != null ? other.LureInfo.Clone() : null;
      cooldownCompleteTimestampMs_ = other.cooldownCompleteTimestampMs_;
      sponsor_ = other.sponsor_;
      renderingType_ = other.renderingType_;
      deployLockoutEndMs_ = other.deployLockoutEndMs_;
    }

    public FortData Clone() {
      return new FortData(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_modified_timestamp_ms" field.</summary>
    public const int LastModifiedTimestampMsFieldNumber = 2;
    private long lastModifiedTimestampMs_;
    public long LastModifiedTimestampMs {
      get { return lastModifiedTimestampMs_; }
      set {
        lastModifiedTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "latitude" field.</summary>
    public const int LatitudeFieldNumber = 3;
    private double latitude_;
    public double Latitude {
      get { return latitude_; }
      set {
        latitude_ = value;
      }
    }

    /// <summary>Field number for the "longitude" field.</summary>
    public const int LongitudeFieldNumber = 4;
    private double longitude_;
    public double Longitude {
      get { return longitude_; }
      set {
        longitude_ = value;
      }
    }

    /// <summary>Field number for the "owned_by_team" field.</summary>
    public const int OwnedByTeamFieldNumber = 5;
    private global::POGOProtos.Enums.TeamColor ownedByTeam_ = 0;
    /// <summary>
    ///  (Gym only) Team that owns the gym.
    /// </summary>
    public global::POGOProtos.Enums.TeamColor OwnedByTeam {
      get { return ownedByTeam_; }
      set {
        ownedByTeam_ = value;
      }
    }

    /// <summary>Field number for the "guard_pokemon_id" field.</summary>
    public const int GuardPokemonIdFieldNumber = 6;
    private global::POGOProtos.Enums.PokemonId guardPokemonId_ = 0;
    /// <summary>
    ///  (Gym only) Highest CP Pokemon ID at the gym.
    /// </summary>
    public global::POGOProtos.Enums.PokemonId GuardPokemonId {
      get { return guardPokemonId_; }
      set {
        guardPokemonId_ = value;
      }
    }

    /// <summary>Field number for the "guard_pokemon_cp" field.</summary>
    public const int GuardPokemonCpFieldNumber = 7;
    private int guardPokemonCp_;
    /// <summary>
    ///  (Gym only) Highest CP Pokemon at the gym.
    /// </summary>
    public int GuardPokemonCp {
      get { return guardPokemonCp_; }
      set {
        guardPokemonCp_ = value;
      }
    }

    /// <summary>Field number for the "enabled" field.</summary>
    public const int EnabledFieldNumber = 8;
    private bool enabled_;
    public bool Enabled {
      get { return enabled_; }
      set {
        enabled_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 9;
    private global::POGOProtos.Map.Fort.FortType type_ = 0;
    public global::POGOProtos.Map.Fort.FortType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "gym_points" field.</summary>
    public const int GymPointsFieldNumber = 10;
    private long gymPoints_;
    /// <summary>
    ///  (Gym only) Prestigate / experience of the gym.
    /// </summary>
    public long GymPoints {
      get { return gymPoints_; }
      set {
        gymPoints_ = value;
      }
    }

    /// <summary>Field number for the "is_in_battle" field.</summary>
    public const int IsInBattleFieldNumber = 11;
    private bool isInBattle_;
    /// <summary>
    ///  (Gym only) Whether someone is battling at the gym currently.
    /// </summary>
    public bool IsInBattle {
      get { return isInBattle_; }
      set {
        isInBattle_ = value;
      }
    }

    /// <summary>Field number for the "active_fort_modifier" field.</summary>
    public const int ActiveFortModifierFieldNumber = 12;
    private static readonly pb::FieldCodec<global::POGOProtos.Inventory.Item.ItemId> _repeated_activeFortModifier_codec
        = pb::FieldCodec.ForEnum(98, x => (int) x, x => (global::POGOProtos.Inventory.Item.ItemId) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemId> activeFortModifier_ = new pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemId>();
    /// <summary>
    ///  (Pokestop only)
    /// </summary>
    public pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemId> ActiveFortModifier {
      get { return activeFortModifier_; }
    }

    /// <summary>Field number for the "lure_info" field.</summary>
    public const int LureInfoFieldNumber = 13;
    private global::POGOProtos.Map.Fort.FortLureInfo lureInfo_;
    /// <summary>
    ///  (Pokestop only)
    /// </summary>
    public global::POGOProtos.Map.Fort.FortLureInfo LureInfo {
      get { return lureInfo_; }
      set {
        lureInfo_ = value;
      }
    }

    /// <summary>Field number for the "cooldown_complete_timestamp_ms" field.</summary>
    public const int CooldownCompleteTimestampMsFieldNumber = 14;
    private long cooldownCompleteTimestampMs_;
    /// <summary>
    ///  (Pokestop only) Timestamp when the pokestop can be activated again to get items / xp.
    /// </summary>
    public long CooldownCompleteTimestampMs {
      get { return cooldownCompleteTimestampMs_; }
      set {
        cooldownCompleteTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "sponsor" field.</summary>
    public const int SponsorFieldNumber = 15;
    private global::POGOProtos.Map.Fort.FortSponsor sponsor_ = 0;
    public global::POGOProtos.Map.Fort.FortSponsor Sponsor {
      get { return sponsor_; }
      set {
        sponsor_ = value;
      }
    }

    /// <summary>Field number for the "rendering_type" field.</summary>
    public const int RenderingTypeFieldNumber = 16;
    private global::POGOProtos.Map.Fort.FortRenderingType renderingType_ = 0;
    public global::POGOProtos.Map.Fort.FortRenderingType RenderingType {
      get { return renderingType_; }
      set {
        renderingType_ = value;
      }
    }

    /// <summary>Field number for the "deploy_lockout_end_ms" field.</summary>
    public const int DeployLockoutEndMsFieldNumber = 17;
    private long deployLockoutEndMs_;
    public long DeployLockoutEndMs {
      get { return deployLockoutEndMs_; }
      set {
        deployLockoutEndMs_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as FortData);
    }

    public bool Equals(FortData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (LastModifiedTimestampMs != other.LastModifiedTimestampMs) return false;
      if (Latitude != other.Latitude) return false;
      if (Longitude != other.Longitude) return false;
      if (OwnedByTeam != other.OwnedByTeam) return false;
      if (GuardPokemonId != other.GuardPokemonId) return false;
      if (GuardPokemonCp != other.GuardPokemonCp) return false;
      if (Enabled != other.Enabled) return false;
      if (Type != other.Type) return false;
      if (GymPoints != other.GymPoints) return false;
      if (IsInBattle != other.IsInBattle) return false;
      if(!activeFortModifier_.Equals(other.activeFortModifier_)) return false;
      if (!object.Equals(LureInfo, other.LureInfo)) return false;
      if (CooldownCompleteTimestampMs != other.CooldownCompleteTimestampMs) return false;
      if (Sponsor != other.Sponsor) return false;
      if (RenderingType != other.RenderingType) return false;
      if (DeployLockoutEndMs != other.DeployLockoutEndMs) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (LastModifiedTimestampMs != 0L) hash ^= LastModifiedTimestampMs.GetHashCode();
      if (Latitude != 0D) hash ^= Latitude.GetHashCode();
      if (Longitude != 0D) hash ^= Longitude.GetHashCode();
      if (OwnedByTeam != 0) hash ^= OwnedByTeam.GetHashCode();
      if (GuardPokemonId != 0) hash ^= GuardPokemonId.GetHashCode();
      if (GuardPokemonCp != 0) hash ^= GuardPokemonCp.GetHashCode();
      if (Enabled != false) hash ^= Enabled.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (GymPoints != 0L) hash ^= GymPoints.GetHashCode();
      if (IsInBattle != false) hash ^= IsInBattle.GetHashCode();
      hash ^= activeFortModifier_.GetHashCode();
      if (lureInfo_ != null) hash ^= LureInfo.GetHashCode();
      if (CooldownCompleteTimestampMs != 0L) hash ^= CooldownCompleteTimestampMs.GetHashCode();
      if (Sponsor != 0) hash ^= Sponsor.GetHashCode();
      if (RenderingType != 0) hash ^= RenderingType.GetHashCode();
      if (DeployLockoutEndMs != 0L) hash ^= DeployLockoutEndMs.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (LastModifiedTimestampMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(LastModifiedTimestampMs);
      }
      if (Latitude != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Latitude);
      }
      if (Longitude != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Longitude);
      }
      if (OwnedByTeam != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) OwnedByTeam);
      }
      if (GuardPokemonId != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) GuardPokemonId);
      }
      if (GuardPokemonCp != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(GuardPokemonCp);
      }
      if (Enabled != false) {
        output.WriteRawTag(64);
        output.WriteBool(Enabled);
      }
      if (Type != 0) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Type);
      }
      if (GymPoints != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(GymPoints);
      }
      if (IsInBattle != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsInBattle);
      }
      activeFortModifier_.WriteTo(output, _repeated_activeFortModifier_codec);
      if (lureInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(LureInfo);
      }
      if (CooldownCompleteTimestampMs != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(CooldownCompleteTimestampMs);
      }
      if (Sponsor != 0) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Sponsor);
      }
      if (RenderingType != 0) {
        output.WriteRawTag(128, 1);
        output.WriteEnum((int) RenderingType);
      }
      if (DeployLockoutEndMs != 0L) {
        output.WriteRawTag(136, 1);
        output.WriteInt64(DeployLockoutEndMs);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (LastModifiedTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastModifiedTimestampMs);
      }
      if (Latitude != 0D) {
        size += 1 + 8;
      }
      if (Longitude != 0D) {
        size += 1 + 8;
      }
      if (OwnedByTeam != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OwnedByTeam);
      }
      if (GuardPokemonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GuardPokemonId);
      }
      if (GuardPokemonCp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GuardPokemonCp);
      }
      if (Enabled != false) {
        size += 1 + 1;
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (GymPoints != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(GymPoints);
      }
      if (IsInBattle != false) {
        size += 1 + 1;
      }
      size += activeFortModifier_.CalculateSize(_repeated_activeFortModifier_codec);
      if (lureInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LureInfo);
      }
      if (CooldownCompleteTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CooldownCompleteTimestampMs);
      }
      if (Sponsor != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Sponsor);
      }
      if (RenderingType != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) RenderingType);
      }
      if (DeployLockoutEndMs != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(DeployLockoutEndMs);
      }
      return size;
    }

    public void MergeFrom(FortData other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.LastModifiedTimestampMs != 0L) {
        LastModifiedTimestampMs = other.LastModifiedTimestampMs;
      }
      if (other.Latitude != 0D) {
        Latitude = other.Latitude;
      }
      if (other.Longitude != 0D) {
        Longitude = other.Longitude;
      }
      if (other.OwnedByTeam != 0) {
        OwnedByTeam = other.OwnedByTeam;
      }
      if (other.GuardPokemonId != 0) {
        GuardPokemonId = other.GuardPokemonId;
      }
      if (other.GuardPokemonCp != 0) {
        GuardPokemonCp = other.GuardPokemonCp;
      }
      if (other.Enabled != false) {
        Enabled = other.Enabled;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.GymPoints != 0L) {
        GymPoints = other.GymPoints;
      }
      if (other.IsInBattle != false) {
        IsInBattle = other.IsInBattle;
      }
      activeFortModifier_.Add(other.activeFortModifier_);
      if (other.lureInfo_ != null) {
        if (lureInfo_ == null) {
          lureInfo_ = new global::POGOProtos.Map.Fort.FortLureInfo();
        }
        LureInfo.MergeFrom(other.LureInfo);
      }
      if (other.CooldownCompleteTimestampMs != 0L) {
        CooldownCompleteTimestampMs = other.CooldownCompleteTimestampMs;
      }
      if (other.Sponsor != 0) {
        Sponsor = other.Sponsor;
      }
      if (other.RenderingType != 0) {
        RenderingType = other.RenderingType;
      }
      if (other.DeployLockoutEndMs != 0L) {
        DeployLockoutEndMs = other.DeployLockoutEndMs;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 16: {
            LastModifiedTimestampMs = input.ReadInt64();
            break;
          }
          case 25: {
            Latitude = input.ReadDouble();
            break;
          }
          case 33: {
            Longitude = input.ReadDouble();
            break;
          }
          case 40: {
            ownedByTeam_ = (global::POGOProtos.Enums.TeamColor) input.ReadEnum();
            break;
          }
          case 48: {
            guardPokemonId_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
            break;
          }
          case 56: {
            GuardPokemonCp = input.ReadInt32();
            break;
          }
          case 64: {
            Enabled = input.ReadBool();
            break;
          }
          case 72: {
            type_ = (global::POGOProtos.Map.Fort.FortType) input.ReadEnum();
            break;
          }
          case 80: {
            GymPoints = input.ReadInt64();
            break;
          }
          case 88: {
            IsInBattle = input.ReadBool();
            break;
          }
          case 98:
          case 96: {
            activeFortModifier_.AddEntriesFrom(input, _repeated_activeFortModifier_codec);
            break;
          }
          case 106: {
            if (lureInfo_ == null) {
              lureInfo_ = new global::POGOProtos.Map.Fort.FortLureInfo();
            }
            input.ReadMessage(lureInfo_);
            break;
          }
          case 112: {
            CooldownCompleteTimestampMs = input.ReadInt64();
            break;
          }
          case 120: {
            sponsor_ = (global::POGOProtos.Map.Fort.FortSponsor) input.ReadEnum();
            break;
          }
          case 128: {
            renderingType_ = (global::POGOProtos.Map.Fort.FortRenderingType) input.ReadEnum();
            break;
          }
          case 136: {
            DeployLockoutEndMs = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
