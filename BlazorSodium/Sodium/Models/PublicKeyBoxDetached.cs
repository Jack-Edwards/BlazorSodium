using System;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium.Models
{
   public class PublicKeyBoxDetached
   {
      public byte[] MessageAuthenticationCode { get; init; }
      public byte[] Cipher { get; init; }

      public PublicKeyBoxDetached(byte[] messageAuthenticationCode, byte[] cipher)
      {
         MessageAuthenticationCode = messageAuthenticationCode;
         Cipher = cipher;
      }

      [SupportedOSPlatform("browser")]
      public static PublicKeyBoxDetached FromJavaScript(JSObject jsObject)
      {
         byte[] mac = jsObject.GetPropertyAsByteArray("mac")
            ?? throw new NullReferenceException("'mac' cannot be null.");
         
         byte[] cipher = jsObject.GetPropertyAsByteArray("ciphertext")
            ?? throw new NullReferenceException("'ciphertext' cannot be null.");
         
         return new PublicKeyBoxDetached(mac, cipher);
      }
   }
}
