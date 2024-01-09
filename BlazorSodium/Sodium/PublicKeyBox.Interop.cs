using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class PublicKeyBox
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_beforenm.json"/>
      [JSImport("sodium.crypto_box_beforenm", "blazorSodium")]
      internal static partial byte[] Crypto_Box_Before_NM_Interop(byte[] publicKey, byte[] privateKey);

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
      internal static partial JSObject Crypto_Box_Curve25519XChaCha20Poly1305_KeyPair_Interop();
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
      internal static partial JSObject Crypto_Box_Detached_Interop(byte[] message, byte[] nonce, byte[] publicKey, byte[] privateKey);

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
      internal static partial JSObject Crypto_Box_Detached_Interop(string message, byte[] nonce, byte[] publicKey, byte[] privateKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns>A sequence of bytes containing the encrypted message and authentication tag.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy.json"/>
      [JSImport("sodium.crypto_box_easy", "blazorSodium")]
      internal static partial byte[] Crypto_Box_Easy_Interop(byte[] message, byte[] nonce, byte[] publicKey, byte[] privateKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns>A sequence of bytes containing the encrypted message and authentication tag.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy.json"/>
      [JSImport("sodium.crypto_box_easy", "blazorSodium")]
      internal static partial byte[] Crypto_Box_Easy_Interop(string message, byte[] nonce, byte[] publicKey, byte[] privateKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="secretKey"></param>
      /// <returns>A sequence of bytes containing the encrypted message and authentication tag.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy_afternm.json"/>
      [JSImport("crypto_box_easy_afternm", "blazorSodium")]
      internal static partial byte[] Crypto_Box_Easy_After_NM_Interop(byte[] message, byte[] nonce, byte[] secretKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="secretKey"></param>
      /// <returns>A sequence of bytes containing the encrypted message and authentication tag.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy_afternm.json"/>
      [JSImport("crypto_box_easy_afternm", "blazorSodium")]
      internal static partial byte[] Crypto_Box_Easy_After_NM_Interop(string message, byte[] nonce, byte[] secretKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_keypair.json"/>
      [JSImport("sodium.crypto_box_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Box_KeyPair_Interop();

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
      internal static partial byte[] Crypto_Box_Open_Detached_Interop(byte[] ciphertext, byte[] mac, byte[] nonce, byte[] publicKey, byte[] privateKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy.json"/>
      [JSImport("sodium.crypto_box_easy", "blazorSodium")]
      internal static partial byte[] Crypto_Box_Open_Easy_Interop(byte[] message, byte[] nonce, byte[] publicKey, byte[] privateKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="sharedKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy_afternm.json"/>
      [JSImport("sodium.crypto_box_open_easy_afternm", "blazorSodium")]
      internal static partial byte[] Crypto_Box_Open_Easy_After_NM_Interop(byte[] message, byte[] nonce, byte[] sharedKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_seed_keypair.json"/>
      [JSImport("sodium.crypto_box_seed_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Box_Seed_KeyPair_Interop(byte[] seed);
   }
}
