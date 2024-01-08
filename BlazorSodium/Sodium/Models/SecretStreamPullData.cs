using System;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium.Models
{
   public class SecretStreamPullData
   {
      public byte[] Message { get; init; }
      public uint Tag { get; init; }

      public SecretStreamPullData(byte[] message, uint tag)
      {
         Message = message;
         Tag = tag;
      }

      [SupportedOSPlatform("browser")]
      public static SecretStreamPullData FromJavaScript(JSObject jsObject)
      {
         byte[] message = jsObject.GetPropertyAsByteArray("message")
            ?? throw new NullReferenceException("'message' cannot be null.");
         
         uint tag = (uint)jsObject.GetPropertyAsInt32("tag");
         return new SecretStreamPullData(message, tag);
      }
   }
}
