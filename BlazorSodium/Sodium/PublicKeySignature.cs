using BlazorSodium.Sodium.Models;
using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class PublicKeySignature
   {
      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_keypair.json"/>
      [JSImport("sodium.crypto_sign_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Sign_KeyPair_Internal();

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_keypair.json"/>
      public static KeyPair Crypto_Sign_KeyPair()
      {
         JSObject jsObject = Crypto_Sign_KeyPair_Internal();
         string keyType = jsObject.GetPropertyAsString("keyType");
         byte[] privateKey = jsObject.GetPropertyAsByteArray("privateKey");
         byte[] publicKey = jsObject.GetPropertyAsByteArray("publicKey");
         return new KeyPair(keyType, privateKey, publicKey);
      }
   }
}
