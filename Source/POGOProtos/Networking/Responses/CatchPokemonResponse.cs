// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/CatchPokemonResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/CatchPokemonResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class CatchPokemonResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/CatchPokemonResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CatchPokemonResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjpQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0NhdGNoUG9rZW1v",
            "blJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
            "c2VzGipQT0dPUHJvdG9zL0RhdGEvQ2FwdHVyZS9DYXB0dXJlQXdhcmQucHJv",
            "dG8i3AMKFENhdGNoUG9rZW1vblJlc3BvbnNlElEKBnN0YXR1cxgBIAEoDjJB",
            "LlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuQ2F0Y2hQb2tlbW9u",
            "UmVzcG9uc2UuQ2F0Y2hTdGF0dXMSFAoMbWlzc19wZXJjZW50GAIgASgBEhsK",
            "E2NhcHR1cmVkX3Bva2Vtb25faWQYAyABKAYSPAoNY2FwdHVyZV9hd2FyZBgE",
            "IAEoCzIlLlBPR09Qcm90b3MuRGF0YS5DYXB0dXJlLkNhcHR1cmVBd2FyZBJb",
            "Cg5jYXB0dXJlX3JlYXNvbhgFIAEoDjJDLlBPR09Qcm90b3MuTmV0d29ya2lu",
            "Zy5SZXNwb25zZXMuQ2F0Y2hQb2tlbW9uUmVzcG9uc2UuQ2FwdHVyZVJlYXNv",
            "biJlCgtDYXRjaFN0YXR1cxIPCgtDQVRDSF9FUlJPUhAAEhEKDUNBVENIX1NV",
            "Q0NFU1MQARIQCgxDQVRDSF9FU0NBUEUQAhIOCgpDQVRDSF9GTEVFEAMSEAoM",
            "Q0FUQ0hfTUlTU0VEEAQiPAoNQ2FwdHVyZVJlYXNvbhIJCgVVTlNFVBAAEgsK",
            "B0RFRkFVTFQQARITCg9FTEVNRU5UQUxfQkFER0UQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Capture.CaptureAwardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.CatchPokemonResponse), global::POGOProtos.Networking.Responses.CatchPokemonResponse.Parser, new[]{ "Status", "MissPercent", "CapturedPokemonId", "CaptureAward", "CaptureReason" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CatchStatus), typeof(global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CaptureReason) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CatchPokemonResponse : pb::IMessage<CatchPokemonResponse> {
    private static readonly pb::MessageParser<CatchPokemonResponse> _parser = new pb::MessageParser<CatchPokemonResponse>(() => new CatchPokemonResponse());
    public static pb::MessageParser<CatchPokemonResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.CatchPokemonResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CatchPokemonResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CatchPokemonResponse(CatchPokemonResponse other) : this() {
      status_ = other.status_;
      missPercent_ = other.missPercent_;
      capturedPokemonId_ = other.capturedPokemonId_;
      CaptureAward = other.captureAward_ != null ? other.CaptureAward.Clone() : null;
      captureReason_ = other.captureReason_;
    }

    public CatchPokemonResponse Clone() {
      return new CatchPokemonResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CatchStatus status_ = 0;
    public global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CatchStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "miss_percent" field.</summary>
    public const int MissPercentFieldNumber = 2;
    private double missPercent_;
    public double MissPercent {
      get { return missPercent_; }
      set {
        missPercent_ = value;
      }
    }

    /// <summary>Field number for the "captured_pokemon_id" field.</summary>
    public const int CapturedPokemonIdFieldNumber = 3;
    private ulong capturedPokemonId_;
    public ulong CapturedPokemonId {
      get { return capturedPokemonId_; }
      set {
        capturedPokemonId_ = value;
      }
    }

    /// <summary>Field number for the "capture_award" field.</summary>
    public const int CaptureAwardFieldNumber = 4;
    private global::POGOProtos.Data.Capture.CaptureAward captureAward_;
    public global::POGOProtos.Data.Capture.CaptureAward CaptureAward {
      get { return captureAward_; }
      set {
        captureAward_ = value;
      }
    }

    /// <summary>Field number for the "capture_reason" field.</summary>
    public const int CaptureReasonFieldNumber = 5;
    private global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CaptureReason captureReason_ = 0;
    public global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CaptureReason CaptureReason {
      get { return captureReason_; }
      set {
        captureReason_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as CatchPokemonResponse);
    }

    public bool Equals(CatchPokemonResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (MissPercent != other.MissPercent) return false;
      if (CapturedPokemonId != other.CapturedPokemonId) return false;
      if (!object.Equals(CaptureAward, other.CaptureAward)) return false;
      if (CaptureReason != other.CaptureReason) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (MissPercent != 0D) hash ^= MissPercent.GetHashCode();
      if (CapturedPokemonId != 0UL) hash ^= CapturedPokemonId.GetHashCode();
      if (captureAward_ != null) hash ^= CaptureAward.GetHashCode();
      if (CaptureReason != 0) hash ^= CaptureReason.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (MissPercent != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(MissPercent);
      }
      if (CapturedPokemonId != 0UL) {
        output.WriteRawTag(25);
        output.WriteFixed64(CapturedPokemonId);
      }
      if (captureAward_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CaptureAward);
      }
      if (CaptureReason != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) CaptureReason);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (MissPercent != 0D) {
        size += 1 + 8;
      }
      if (CapturedPokemonId != 0UL) {
        size += 1 + 8;
      }
      if (captureAward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CaptureAward);
      }
      if (CaptureReason != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CaptureReason);
      }
      return size;
    }

    public void MergeFrom(CatchPokemonResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.MissPercent != 0D) {
        MissPercent = other.MissPercent;
      }
      if (other.CapturedPokemonId != 0UL) {
        CapturedPokemonId = other.CapturedPokemonId;
      }
      if (other.captureAward_ != null) {
        if (captureAward_ == null) {
          captureAward_ = new global::POGOProtos.Data.Capture.CaptureAward();
        }
        CaptureAward.MergeFrom(other.CaptureAward);
      }
      if (other.CaptureReason != 0) {
        CaptureReason = other.CaptureReason;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            status_ = (global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CatchStatus) input.ReadEnum();
            break;
          }
          case 17: {
            MissPercent = input.ReadDouble();
            break;
          }
          case 25: {
            CapturedPokemonId = input.ReadFixed64();
            break;
          }
          case 34: {
            if (captureAward_ == null) {
              captureAward_ = new global::POGOProtos.Data.Capture.CaptureAward();
            }
            input.ReadMessage(captureAward_);
            break;
          }
          case 40: {
            captureReason_ = (global::POGOProtos.Networking.Responses.CatchPokemonResponse.Types.CaptureReason) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CatchPokemonResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum CatchStatus {
        [pbr::OriginalName("CATCH_ERROR")] CatchError = 0,
        [pbr::OriginalName("CATCH_SUCCESS")] CatchSuccess = 1,
        [pbr::OriginalName("CATCH_ESCAPE")] CatchEscape = 2,
        [pbr::OriginalName("CATCH_FLEE")] CatchFlee = 3,
        [pbr::OriginalName("CATCH_MISSED")] CatchMissed = 4,
      }

      public enum CaptureReason {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("DEFAULT")] Default = 1,
        [pbr::OriginalName("ELEMENTAL_BADGE")] ElementalBadge = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
