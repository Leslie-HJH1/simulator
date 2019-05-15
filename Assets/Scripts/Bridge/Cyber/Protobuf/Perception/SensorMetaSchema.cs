// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/perception/proto/sensor_meta_schema.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Perception {

  /// <summary>Holder for reflection information generated from modules/perception/proto/sensor_meta_schema.proto</summary>
  public static partial class SensorMetaSchemaReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/perception/proto/sensor_meta_schema.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SensorMetaSchemaReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFtb2R1bGVzL3BlcmNlcHRpb24vcHJvdG8vc2Vuc29yX21ldGFfc2NoZW1h",
            "LnByb3RvEhFhcG9sbG8ucGVyY2VwdGlvbiKtBAoKU2Vuc29yTWV0YRIMCgRu",
            "YW1lGAEgASgJEjYKBHR5cGUYAiABKA4yKC5hcG9sbG8ucGVyY2VwdGlvbi5T",
            "ZW5zb3JNZXRhLlNlbnNvclR5cGUSRAoLb3JpZW50YXRpb24YAyABKA4yLy5h",
            "cG9sbG8ucGVyY2VwdGlvbi5TZW5zb3JNZXRhLlNlbnNvck9yaWVudGF0aW9u",
            "IvcBCgpTZW5zb3JUeXBlEg8KC1ZFTE9EWU5FXzY0EAASIAoTVU5LTk9XTl9T",
            "RU5TT1JfVFlQRRD///////////8BEg8KC1ZFTE9EWU5FXzMyEAESDwoLVkVM",
            "T0RZTkVfMTYQAhINCglMRExJREFSXzQQAxINCglMRExJREFSXzEQBBIVChFT",
            "SE9SVF9SQU5HRV9SQURBUhAFEhQKEExPTkdfUkFOR0VfUkFEQVIQBhIUChBN",
            "T05PQ1VMQVJfQ0FNRVJBEAcSEQoNU1RFUkVPX0NBTUVSQRAIEg4KClVMVFJB",
            "U09OSUMQCRIQCgxWRUxPRFlORV8xMjgQCiKYAQoRU2Vuc29yT3JpZW50YXRp",
            "b24SCQoFRlJPTlQQABIQCgxMRUZUX0ZPUldBUkQQARIICgRMRUZUEAISEQoN",
            "TEVGVF9CQUNLV0FSRBADEggKBFJFQVIQBBISCg5SSUdIVF9CQUNLV0FSRBAF",
            "EgkKBVJJR0hUEAYSEQoNUklHSFRfRk9SV0FSRBAHEg0KCVBBTk9SQU1JQxAI",
            "IkUKD011bHRpU2Vuc29yTWV0YRIyCgtzZW5zb3JfbWV0YRgBIAMoCzIdLmFw",
            "b2xsby5wZXJjZXB0aW9uLlNlbnNvck1ldGFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Perception.SensorMeta), global::Apollo.Perception.SensorMeta.Parser, new[]{ "Name", "Type", "Orientation" }, null, new[]{ typeof(global::Apollo.Perception.SensorMeta.Types.SensorType), typeof(global::Apollo.Perception.SensorMeta.Types.SensorOrientation) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Perception.MultiSensorMeta), global::Apollo.Perception.MultiSensorMeta.Parser, new[]{ "SensorMeta" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SensorMeta : pb::IMessage<SensorMeta> {
    private static readonly pb::MessageParser<SensorMeta> _parser = new pb::MessageParser<SensorMeta>(() => new SensorMeta());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SensorMeta> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Perception.SensorMetaSchemaReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SensorMeta() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SensorMeta(SensorMeta other) : this() {
      name_ = other.name_;
      type_ = other.type_;
      orientation_ = other.orientation_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SensorMeta Clone() {
      return new SensorMeta(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::Apollo.Perception.SensorMeta.Types.SensorType type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Perception.SensorMeta.Types.SensorType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "orientation" field.</summary>
    public const int OrientationFieldNumber = 3;
    private global::Apollo.Perception.SensorMeta.Types.SensorOrientation orientation_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Perception.SensorMeta.Types.SensorOrientation Orientation {
      get { return orientation_; }
      set {
        orientation_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SensorMeta);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SensorMeta other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Type != other.Type) return false;
      if (Orientation != other.Orientation) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Orientation != 0) hash ^= Orientation.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (Orientation != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Orientation);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Orientation != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Orientation);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SensorMeta other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Orientation != 0) {
        Orientation = other.Orientation;
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            type_ = (global::Apollo.Perception.SensorMeta.Types.SensorType) input.ReadEnum();
            break;
          }
          case 24: {
            orientation_ = (global::Apollo.Perception.SensorMeta.Types.SensorOrientation) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SensorMeta message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum SensorType {
        [pbr::OriginalName("VELODYNE_64")] Velodyne64 = 0,
        [pbr::OriginalName("UNKNOWN_SENSOR_TYPE")] UnknownSensorType = -1,
        [pbr::OriginalName("VELODYNE_32")] Velodyne32 = 1,
        [pbr::OriginalName("VELODYNE_16")] Velodyne16 = 2,
        [pbr::OriginalName("LDLIDAR_4")] Ldlidar4 = 3,
        [pbr::OriginalName("LDLIDAR_1")] Ldlidar1 = 4,
        [pbr::OriginalName("SHORT_RANGE_RADAR")] ShortRangeRadar = 5,
        [pbr::OriginalName("LONG_RANGE_RADAR")] LongRangeRadar = 6,
        [pbr::OriginalName("MONOCULAR_CAMERA")] MonocularCamera = 7,
        [pbr::OriginalName("STEREO_CAMERA")] StereoCamera = 8,
        [pbr::OriginalName("ULTRASONIC")] Ultrasonic = 9,
        [pbr::OriginalName("VELODYNE_128")] Velodyne128 = 10,
      }

      public enum SensorOrientation {
        [pbr::OriginalName("FRONT")] Front = 0,
        [pbr::OriginalName("LEFT_FORWARD")] LeftForward = 1,
        [pbr::OriginalName("LEFT")] Left = 2,
        [pbr::OriginalName("LEFT_BACKWARD")] LeftBackward = 3,
        [pbr::OriginalName("REAR")] Rear = 4,
        [pbr::OriginalName("RIGHT_BACKWARD")] RightBackward = 5,
        [pbr::OriginalName("RIGHT")] Right = 6,
        [pbr::OriginalName("RIGHT_FORWARD")] RightForward = 7,
        [pbr::OriginalName("PANORAMIC")] Panoramic = 8,
      }

    }
    #endregion

  }

  public sealed partial class MultiSensorMeta : pb::IMessage<MultiSensorMeta> {
    private static readonly pb::MessageParser<MultiSensorMeta> _parser = new pb::MessageParser<MultiSensorMeta>(() => new MultiSensorMeta());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MultiSensorMeta> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Perception.SensorMetaSchemaReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MultiSensorMeta() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MultiSensorMeta(MultiSensorMeta other) : this() {
      sensorMeta_ = other.sensorMeta_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MultiSensorMeta Clone() {
      return new MultiSensorMeta(this);
    }

    /// <summary>Field number for the "sensor_meta" field.</summary>
    public const int SensorMetaFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Apollo.Perception.SensorMeta> _repeated_sensorMeta_codec
        = pb::FieldCodec.ForMessage(10, global::Apollo.Perception.SensorMeta.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Perception.SensorMeta> sensorMeta_ = new pbc::RepeatedField<global::Apollo.Perception.SensorMeta>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Perception.SensorMeta> SensorMeta {
      get { return sensorMeta_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MultiSensorMeta);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MultiSensorMeta other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sensorMeta_.Equals(other.sensorMeta_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sensorMeta_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      sensorMeta_.WriteTo(output, _repeated_sensorMeta_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += sensorMeta_.CalculateSize(_repeated_sensorMeta_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MultiSensorMeta other) {
      if (other == null) {
        return;
      }
      sensorMeta_.Add(other.sensorMeta_);
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
            sensorMeta_.AddEntriesFrom(input, _repeated_sensorMeta_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code