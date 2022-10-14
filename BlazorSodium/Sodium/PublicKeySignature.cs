using BlazorSodium.Sodium.Models;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   public static partial class PublicKeySignature
   {
      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_keypair.json"/>
      [SupportedOSPlatform("browser")]
      public static Ed25519KeyPair Crypto_Sign_KeyPair()
      {
         JSObject jsObject = Crypto_Sign_KeyPair_Internal();
         return Ed25519KeyPair.FromJavaScript(jsObject);
      }

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
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_seed_keypair.json"/>
      [SupportedOSPlatform("browser")]
      public static Ed25519KeyPair Crypto_Sign_Seed_KeyPair(byte[] seed)
      {
         JSObject jsObject = Crypto_Sign_Seed_KeyPair_Internal(seed);
         return Ed25519KeyPair.FromJavaScript(jsObject);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_seed_keypair.json"/>
      [JSImport("sodium.crypto_sign_seed_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Sign_Seed_KeyPair_Internal(byte[] seed);
   }
}
