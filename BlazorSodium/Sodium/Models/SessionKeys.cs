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
         byte[] receiveKey = jsObject.GetPropertyAsByteArray("sharedRx")
            ?? throw new NullReferenceException("'sharedRx' cannot be null.");
         
         byte[] transmitKey = jsObject.GetPropertyAsByteArray("sharedTx")
            ?? throw new NullReferenceException("'sharedTx' cannot be null.");
         
         return new SessionKeys(receiveKey, transmitKey);
      }
   }
}
