//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: MessageCountCommand.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MessageCountCommand")]
  public partial class MessageCountCommand : global::ProtoBuf.IExtensible
  {
    public MessageCountCommand() {}
    

    private long _requestId = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"requestId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long requestId
    {
      get { return _requestId; }
      set { _requestId = value; }
    }

    private string _topicName = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"topicName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string topicName
    {
      get { return _topicName; }
      set { _topicName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}