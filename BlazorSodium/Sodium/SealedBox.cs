using BlazorSodium.Sodium.Models;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   public static partial class SealedBox
   {
      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_keypair.json"/>
      [SupportedOSPlatform("browser")]
      public static X25519KeyPair Crypto_Box_KeyPair()
      {
         JSObject jsObject = Crypto_Box_KeyPair_Internal();
         return X25519KeyPair.FromJavaScript(jsObject);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_keypair.json"/>
      [JSImport("sodium.crypto_box_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Box_KeyPair_Internal();

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <remarks>
      /// Avoid this method unless you explicitly need to use the XChaCha20 algorithm.
      /// </remarks>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_curve25519xchacha20poly1305_keypair.json"/>
      /// <seealso cref="https://github.com/jedisct1/libsodium/discussions/1101"/>
      [SupportedOSPlatform("browser")]
      public static Curve25519KeyPair Crypto_Box_Curve25519XChaCha20Poly1305_KeyPair()
      {
         JSObject jsObject = Crypto_Box_Curve25519XChaCha20Poly1305_KeyPair_Internal();
         return Curve25519KeyPair.FromJavaScript(jsObject);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <remarks>
      /// Avoid this method unless you explicitly need to use the XChaCha20 algorithm.
      /// </remarks>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_curve25519xchacha20poly1305_keypair.json"/>
      /// <seealso cref="https://github.com/jedisct1/libsodium/discussions/1101"/>
      [JSImport("sodium.crypto_box_curve25519xchacha20poly1305_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Box_Curve25519XChaCha20Poly1305_KeyPair_Internal();

      /// <summary>
      /// 
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_seed_keypair.json"/>
      [SupportedOSPlatform("browser")]
      public static X25519KeyPair Crypto_Box_Seed_KeyPair(byte[] seed)
      {
         JSObject jsObject = Crypto_Box_Seed_KeyPair_Internal(seed);
         return X25519KeyPair.FromJavaScript(jsObject);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_seed_keypair.json"/>
      [JSImport("sodium.crypto_box_seed_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Box_Seed_KeyPair_Internal(byte[] seed);
   }
}
