// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: messagePro.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Zero.ZeroEngine.Message {

  /// <summary>Holder for reflection information generated from messagePro.proto</summary>
  public static partial class MessageProReflection {

    #region Descriptor
    /// <summary>File descriptor for messagePro.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageProReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBtZXNzYWdlUHJvLnByb3RvKnwKCU1lc3NhZ2VJRBIKCgZDX1plcm8QABIM",
            "CgZDX1Rlc3QQoY0GEhAKC1NfRXhjZXB0aW9uEOgHEhcKElNfRXhjZXB0aW9u",
            "X1NlcnZlchDpBxIUCg9DX0dldFNlcnZlclRpbWUQsAkSFAoPU19HZXRTZXJ2",
            "ZXJUaW1lELEJQjkKC2NvbS5tZXNzYWdlQhBNZXNzYWdlRW51bVByb3RvqgIX",
            "WmVyby5aZXJvRW5naW5lLk1lc3NhZ2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Zero.ZeroEngine.Message.MessageID), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MessageID {
    [pbr::OriginalName("C_Zero")] CZero = 0,
    /// <summary>
    /// 测试消息100000以上
    /// </summary>
    [pbr::OriginalName("C_Test")] CTest = 100001,
    /// <summary>
    ///错误码
    /// </summary>
    [pbr::OriginalName("S_Exception")] SException = 1000,
    /// <summary>
    ///服务端组装文字提示
    /// </summary>
    [pbr::OriginalName("S_Exception_Server")] SExceptionServer = 1001,
    /// <summary>
    ///心跳  一分钟调用一次
    /// </summary>
    [pbr::OriginalName("C_GetServerTime")] CGetServerTime = 1200,
    /// <summary>
    ///心跳  一分钟调用一次
    /// </summary>
    [pbr::OriginalName("S_GetServerTime")] SGetServerTime = 1201,
  }

  #endregion

}

#endregion Designer generated code
