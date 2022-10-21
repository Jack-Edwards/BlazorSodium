using System;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium.Models
{
   public class SessionKeys
   {
      public byte[] ReceiveKey { get; init; }
      public byte[] TransmitKey { get; init; }

      public SessionKeys(byte[] receiveKey, byte[] transmitKey)
      {
         ReceiveKey = receiveKey;
         TransmitKey = transmitKey;
      }

      [SupportedOSPlatform("browser")]
      public static SessionKeys FromJavaScript(JSObject jsObject)
      {
         byte[] receiveKey = jsObject.GetPropertyAsByteArray("sharedRx");
         byte[] transmitKey = jsObject.GetPropertyAsByteArray("sharedTx");
         return new SessionKeys(receiveKey, transmitKey);
      }
   }
}
