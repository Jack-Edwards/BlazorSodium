using System;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium.Models
{
   public class Curve25519KeyPair : IKeyPair
   {
      private const string _keyType = "curve25519";

      public byte[] PrivateKey { get; init; }
      public byte[] PublicKey { get; init; }

      public Curve25519KeyPair(byte[] privateKey, byte[] publicKey)
      {
         PrivateKey = privateKey;
         PublicKey = publicKey;
      }

      [SupportedOSPlatform("browser")]
      public static Curve25519KeyPair FromJavaScript(JSObject jsObject)
      {
         string keyType = jsObject.GetPropertyAsString("keyType");
         if (keyType != _keyType)
         {
            throw new ArgumentException($"'{keyType}' is not a valid key type for this class", nameof(jsObject));
         }

         byte[] privateKey = jsObject.GetPropertyAsByteArray("privateKey");
         byte[] publicKey = jsObject.GetPropertyAsByteArray("publicKey");
         return new Curve25519KeyPair(privateKey, publicKey);
      }
   }
}
