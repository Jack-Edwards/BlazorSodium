using System;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium.Models
{
   public class SecretStreamPushData
   {
      public byte[] Header { get; init; }
      public StateAddress StateAddress { get; init; }

      public SecretStreamPushData(byte[] header, StateAddress stateAddress)
      {
         Header = header;
         StateAddress = stateAddress;
      }

      [SupportedOSPlatform("browser")]
      public static SecretStreamPushData FromJavaScript(JSObject jsObject)
      {
         byte[] header = jsObject.GetPropertyAsByteArray("header")
            ?? throw new NullReferenceException("'header' cannot be null.");
         
         int address = jsObject.GetPropertyAsInt32("state");
         StateAddress stateAddress = new StateAddress(address);
         return new SecretStreamPushData(header, stateAddress);
      }
   }
}
