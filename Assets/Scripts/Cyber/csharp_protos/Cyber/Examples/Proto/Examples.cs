// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: cyber/examples/proto/examples.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Cyber.Examples.Proto {

  /// <summary>Holder for reflection information generated from cyber/examples/proto/examples.proto</summary>
  public static partial class ExamplesReflection {

    #region Descriptor
    /// <summary>File descriptor for cyber/examples/proto/examples.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExamplesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNjeWJlci9leGFtcGxlcy9wcm90by9leGFtcGxlcy5wcm90bxIbYXBvbGxv",
            "LmN5YmVyLmV4YW1wbGVzLnByb3RvIjUKDFNhbXBsZXNUZXN0MRISCgpjbGFz",
            "c19uYW1lGAEgASgJEhEKCWNhc2VfbmFtZRgCIAEoCSJTCgdDaGF0dGVyEhEK",
            "CXRpbWVzdGFtcBgBIAEoBBIXCg9saWRhcl90aW1lc3RhbXAYAiABKAQSCwoD",
            "c2VxGAMgASgEEg8KB2NvbnRlbnQYBCABKAwiPAoGRHJpdmVyEg8KB2NvbnRl",
            "bnQYASABKAkSDgoGbXNnX2lkGAIgASgEEhEKCXRpbWVzdGFtcBgDIAEoBGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Cyber.Examples.Proto.SamplesTest1), global::Apollo.Cyber.Examples.Proto.SamplesTest1.Parser, new[]{ "ClassName", "CaseName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Cyber.Examples.Proto.Chatter), global::Apollo.Cyber.Examples.Proto.Chatter.Parser, new[]{ "Timestamp", "LidarTimestamp", "Seq", "Content" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Cyber.Examples.Proto.Driver), global::Apollo.Cyber.Examples.Proto.Driver.Parser, new[]{ "Content", "MsgId", "Timestamp" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SamplesTest1 : pb::IMessage<SamplesTest1> {
    private static readonly pb::MessageParser<SamplesTest1> _parser = new pb::MessageParser<SamplesTest1>(() => new SamplesTest1());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SamplesTest1> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Cyber.Examples.Proto.ExamplesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SamplesTest1() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SamplesTest1(SamplesTest1 other) : this() {
      className_ = other.className_;
      caseName_ = other.caseName_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SamplesTest1 Clone() {
      return new SamplesTest1(this);
    }

    /// <summary>Field number for the "class_name" field.</summary>
    public const int ClassNameFieldNumber = 1;
    private string className_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClassName {
      get { return className_; }
      set {
        className_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "case_name" field.</summary>
    public const int CaseNameFieldNumber = 2;
    private string caseName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CaseName {
      get { return caseName_; }
      set {
        caseName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SamplesTest1);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SamplesTest1 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClassName != other.ClassName) return false;
      if (CaseName != other.CaseName) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ClassName.Length != 0) hash ^= ClassName.GetHashCode();
      if (CaseName.Length != 0) hash ^= CaseName.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ClassName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClassName);
      }
      if (CaseName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CaseName);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ClassName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClassName);
      }
      if (CaseName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CaseName);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SamplesTest1 other) {
      if (other == null) {
        return;
      }
      if (other.ClassName.Length != 0) {
        ClassName = other.ClassName;
      }
      if (other.CaseName.Length != 0) {
        CaseName = other.CaseName;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            ClassName = input.ReadString();
            break;
          }
          case 18: {
            CaseName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Chatter : pb::IMessage<Chatter> {
    private static readonly pb::MessageParser<Chatter> _parser = new pb::MessageParser<Chatter>(() => new Chatter());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Chatter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Cyber.Examples.Proto.ExamplesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Chatter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Chatter(Chatter other) : this() {
      timestamp_ = other.timestamp_;
      lidarTimestamp_ = other.lidarTimestamp_;
      seq_ = other.seq_;
      content_ = other.content_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Chatter Clone() {
      return new Chatter(this);
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 1;
    private ulong timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "lidar_timestamp" field.</summary>
    public const int LidarTimestampFieldNumber = 2;
    private ulong lidarTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong LidarTimestamp {
      get { return lidarTimestamp_; }
      set {
        lidarTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "seq" field.</summary>
    public const int SeqFieldNumber = 3;
    private ulong seq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Seq {
      get { return seq_; }
      set {
        seq_ = value;
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 4;
    private pb::ByteString content_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Chatter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Chatter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Timestamp != other.Timestamp) return false;
      if (LidarTimestamp != other.LidarTimestamp) return false;
      if (Seq != other.Seq) return false;
      if (Content != other.Content) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Timestamp != 0UL) hash ^= Timestamp.GetHashCode();
      if (LidarTimestamp != 0UL) hash ^= LidarTimestamp.GetHashCode();
      if (Seq != 0UL) hash ^= Seq.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Timestamp != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Timestamp);
      }
      if (LidarTimestamp != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(LidarTimestamp);
      }
      if (Seq != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Seq);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Content);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Timestamp != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Timestamp);
      }
      if (LidarTimestamp != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(LidarTimestamp);
      }
      if (Seq != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Seq);
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Content);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Chatter other) {
      if (other == null) {
        return;
      }
      if (other.Timestamp != 0UL) {
        Timestamp = other.Timestamp;
      }
      if (other.LidarTimestamp != 0UL) {
        LidarTimestamp = other.LidarTimestamp;
      }
      if (other.Seq != 0UL) {
        Seq = other.Seq;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Timestamp = input.ReadUInt64();
            break;
          }
          case 16: {
            LidarTimestamp = input.ReadUInt64();
            break;
          }
          case 24: {
            Seq = input.ReadUInt64();
            break;
          }
          case 34: {
            Content = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Driver : pb::IMessage<Driver> {
    private static readonly pb::MessageParser<Driver> _parser = new pb::MessageParser<Driver>(() => new Driver());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Driver> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Cyber.Examples.Proto.ExamplesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Driver() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Driver(Driver other) : this() {
      content_ = other.content_;
      msgId_ = other.msgId_;
      timestamp_ = other.timestamp_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Driver Clone() {
      return new Driver(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1;
    private string content_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "msg_id" field.</summary>
    public const int MsgIdFieldNumber = 2;
    private ulong msgId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong MsgId {
      get { return msgId_; }
      set {
        msgId_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 3;
    private ulong timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Driver);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Driver other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      if (MsgId != other.MsgId) return false;
      if (Timestamp != other.Timestamp) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (MsgId != 0UL) hash ^= MsgId.GetHashCode();
      if (Timestamp != 0UL) hash ^= Timestamp.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Content);
      }
      if (MsgId != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(MsgId);
      }
      if (Timestamp != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Timestamp);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (MsgId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(MsgId);
      }
      if (Timestamp != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Timestamp);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Driver other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.MsgId != 0UL) {
        MsgId = other.MsgId;
      }
      if (other.Timestamp != 0UL) {
        Timestamp = other.Timestamp;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Content = input.ReadString();
            break;
          }
          case 16: {
            MsgId = input.ReadUInt64();
            break;
          }
          case 24: {
            Timestamp = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
