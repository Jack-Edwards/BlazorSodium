using System;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium.Models
{
   public enum SessionKeysType
   {
      Client,
      Server
   }

   public class SessionKeys
   {
      public SessionKeysType KeysType { get; init; }
      public byte[] ReceiveKey { get; init; }
      public byte[] TransmitKey { get; init; }

      public SessionKeys(SessionKeysType keysType, byte[] receiveKey, byte[] transmitKey)
      {
         KeysType = keysType;
         ReceiveKey = receiveKey;
         TransmitKey = transmitKey;
      }

      [SupportedOSPlatform("browser")]
      public static SessionKeys FromJavaScript(SessionKeysType keysType, JSObject jsObject)
      {
         byte[] receiveKey = jsObject.GetPropertyAsByteArray("sharedRx");
         byte[] transmitKey = jsObject.GetPropertyAsByteArray("sharedTx");
         return new SessionKeys(keysType, receiveKey, transmitKey);
      }
   }
}
