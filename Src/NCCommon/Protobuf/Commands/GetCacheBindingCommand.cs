//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GetCacheBindingCommand.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetCacheBindingCommand")]
  public partial class GetCacheBindingCommand : global::ProtoBuf.IExtensible
  {
    public GetCacheBindingCommand() {}
    

    private long _requestId = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"requestId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long requestId
    {
      get { return _requestId; }
      set { _requestId = value; }
    }

    private string _cacheId = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"cacheId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cacheId
    {
      get { return _cacheId; }
      set { _cacheId = value; }
    }

    private bool _isRunning = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"isRunning", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool isRunning
    {
      get { return _isRunning; }
      set { _isRunning = value; }
    }

    private string _userId = @"dummyUID";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"userId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(@"dummyUID")]
    public string userId
    {
      get { return _userId; }
      set { _userId = value; }
    }

    private string _pwd = @"dummyPwd";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"pwd", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(@"dummyPwd")]
    public string pwd
    {
      get { return _pwd; }
      set { _pwd = value; }
    }

    private bool _isJavaClient = (bool)true;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"isJavaClient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)true)]
    public bool isJavaClient
    {
      get { return _isJavaClient; }
      set { _isJavaClient = value; }
    }

    private byte[] _binaryUserId = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"binaryUserId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] binaryUserId
    {
      get { return _binaryUserId; }
      set { _binaryUserId = value; }
    }

    private byte[] _binaryPassword = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"binaryPassword", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] binaryPassword
    {
      get { return _binaryPassword; }
      set { _binaryPassword = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
