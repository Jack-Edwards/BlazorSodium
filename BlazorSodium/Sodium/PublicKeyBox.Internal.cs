using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   public static partial class PublicKeyBox
   {
      /* Missing from the sodium module
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <remarks>
      /// Avoid this method unless you explicitly need to use the XChaCha20 algorithm.
      /// </remarks>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_curve25519xchacha20poly1305_keypair.json"/>
      /// <seealso cref="https://github.com/jedisct1/libsodium/discussions/1101"/>
      [JSImport("sodium.crypto_box_curve25519xchacha20poly1305_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Box_Curve25519XChaCha20Poly1305_KeyPair_Internal();
      */

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_detached.json"/>
      [JSImport("sodium.crypto_box_detached", "blazorSodium")]
      internal static partial JSObject Crypto_Box_Detached_Internal(byte[] message, byte[] nonce, byte[] publicKey, byte[] privateKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_detached.json"/>
      [JSImport("sodium.crypto_box_detached", "blazorSodium")]
      internal static partial JSObject Crypto_Box_Detached_Internal(string message, byte[] nonce, byte[] publicKey, byte[] privateKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_keypair.json"/>
      [JSImport("sodium.crypto_box_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Box_KeyPair_Internal();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="ciphertext"></param>
      /// <param name="mac"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_open_detached.json"/>
      [JSImport("sodium.crypto_box_open_detached", "blazorSodium")]
      internal static partial byte[] Crypto_Box_Open_Detached_Internal(byte[] ciphertext, byte[] mac, byte[] nonce, byte[] publicKey, byte[] privateKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_seed_keypair.json"/>
      [JSImport("sodium.crypto_box_seed_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Box_Seed_KeyPair_Internal(byte[] seed);
   }
}
