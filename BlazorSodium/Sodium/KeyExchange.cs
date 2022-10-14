using BlazorSodium.Sodium.Models;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   public static partial class KeyExchange
   {
      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_keypair.json"/>
      [SupportedOSPlatform("browser")]
      public static X25519KeyPair Crypto_KX_KeyPair()
      {
         JSObject jsObject = Crypto_KX_KeyPair_Internal();
         return X25519KeyPair.FromJavaScript(jsObject);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_keypair.json"/>
      [JSImport("sodium.crypto_kx_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_KX_KeyPair_Internal();

      /// <summary>
      /// 
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_seed_keypair.json"/>
      [SupportedOSPlatform("browser")]
      public static X25519KeyPair Crypto_KX_Seed_KeyPair(byte[] seed)
      {
         JSObject jsObject = Crypto_KX_Seed_KeyPair_Internal(seed);
         return X25519KeyPair.FromJavaScript(jsObject);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_seed_keypair.json"/>
      [JSImport("sodium.crypto_kx_seed_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_KX_Seed_KeyPair_Internal(byte[] seed);
   }
}
