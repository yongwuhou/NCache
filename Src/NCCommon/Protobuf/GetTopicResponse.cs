//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GetTopicResponse.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetTopicResponse")]
  public partial class GetTopicResponse : global::ProtoBuf.IExtensible
  {
    public GetTopicResponse() {}
    

    private bool _success = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }

    private int _commandID = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"commandID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int commandID
    {
      get { return _commandID; }
      set { _commandID = value; }
    }

    private long _requestId = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"requestId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long requestId
    {
      get { return _requestId; }
      set { _requestId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}