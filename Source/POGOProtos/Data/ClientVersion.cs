// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/ClientVersion.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/ClientVersion.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ClientVersionReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/ClientVersion.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientVersionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNQT0dPUHJvdG9zL0RhdGEvQ2xpZW50VmVyc2lvbi5wcm90bxIPUE9HT1By",
            "b3Rvcy5EYXRhIiQKDUNsaWVudFZlcnNpb24SEwoLbWluX3ZlcnNpb24YASAB",
            "KAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.ClientVersion), global::POGOProtos.Data.ClientVersion.Parser, new[]{ "MinVersion" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ClientVersion : pb::IMessage<ClientVersion> {
    private static readonly pb::MessageParser<ClientVersion> _parser = new pb::MessageParser<ClientVersion>(() => new ClientVersion());
    public static pb::MessageParser<ClientVersion> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.ClientVersionReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ClientVersion() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ClientVersion(ClientVersion other) : this() {
      minVersion_ = other.minVersion_;
    }

    public ClientVersion Clone() {
      return new ClientVersion(this);
    }

    /// <summary>Field number for the "min_version" field.</summary>
    public const int MinVersionFieldNumber = 1;
    private string minVersion_ = "";
    public string MinVersion {
      get { return minVersion_; }
      set {
        minVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ClientVersion);
    }

    public bool Equals(ClientVersion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MinVersion != other.MinVersion) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (MinVersion.Length != 0) hash ^= MinVersion.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (MinVersion.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MinVersion);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (MinVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MinVersion);
      }
      return size;
    }

    public void MergeFrom(ClientVersion other) {
      if (other == null) {
        return;
      }
      if (other.MinVersion.Length != 0) {
        MinVersion = other.MinVersion;
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
            MinVersion = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
