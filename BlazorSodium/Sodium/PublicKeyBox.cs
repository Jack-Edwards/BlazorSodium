using BlazorSodium.Sodium.Models;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   public static partial class PublicKeyBox
   {
      /// <summary>
      /// Compute a shared key from the provided public and private keys.
      /// </summary>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_beforenm.json"/>
      [JSImport("sodium.crypto_box_beforenm", "blazorSodium")]
      public static partial byte[] Crypto_Box_Before_NM(byte[] publicKey, byte[] privateKey);

      /* Missing from the sodium module
      /// <summary>
      /// Randomly generate a Curve25519 key pair.
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
      */

      /// <summary>
      /// Encrypts a message using the provided keys and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns>An object containing the authentication tag and encrypted message.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static PublicKeyBoxDetached Crypto_Box_Detached(byte[] message, byte[] nonce, byte[] publicKey, byte[] privateKey)
      {
         JSObject jsObject = Crypto_Box_Detached_Internal(message, nonce, publicKey, privateKey);
         return PublicKeyBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts a message using the provided keys and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns>An object containing the authentication tag and encrypted message.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static PublicKeyBoxDetached Crypto_Box_Detached(string message, byte[] nonce, byte[] publicKey, byte[] privateKey)
      {
         JSObject jsObject = Crypto_Box_Detached_Internal(message, nonce, publicKey, privateKey);
         return PublicKeyBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts a message using the provided keys and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns>A sequence of bytes containing the encrypted message and authentication tag.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy.json"/>
      [JSImport("sodium.crypto_box_easy", "blazorSodium")]
      public static partial byte[] Crypto_Box_Easy(byte[] message, byte[] nonce, byte[] publicKey, byte[] privateKey);

      /// <summary>
      /// Encrypts a message using the provided keys and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns>A sequence of bytes containing the encrypted message and authentication tag.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy.json"/>
      [JSImport("sodium.crypto_box_easy", "blazorSodium")]
      public static partial byte[] Crypto_Box_Easy(string message, byte[] nonce, byte[] publicKey, byte[] privateKey);

      /// <summary>
      /// Encrypts a message using a pre-calculated shared key and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="secretKey"></param>
      /// <returns>A sequence of bytes containing the encrypted message and authentication tag.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy_afternm.json"/>
      [JSImport("crypto_box_easy_afternm", "blazorSodium")]
      public static partial byte[] Crypto_Box_Easy_After_NM(byte[] message, byte[] nonce, byte[] secretKey);

      /// <summary>
      /// Encrypts a message using a pre-calculated shared key and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="secretKey"></param>
      /// <returns>A sequence of bytes containing the encrypted message and authentication tag.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy_afternm.json"/>
      [JSImport("crypto_box_easy_afternm", "blazorSodium")]
      public static partial byte[] Crypto_Box_Easy_After_NM(string message, byte[] nonce, byte[] secretKey);

      /// <summary>
      /// Randomly generate an X25519 key pair.
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
      /// Decrypt and verify the provided detached box.
      /// </summary>
      /// <param name="detachedBox"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_open_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_Box_Open_Detached(PublicKeyBoxDetached detachedBox, byte[] nonce, byte[] publicKey, byte[] privateKey)
         => Crypto_Box_Open_Detached_Internal(detachedBox.Cipher, detachedBox.MessageAuthenticationCode, nonce, publicKey, privateKey);

      /// <summary>
      /// Decrypt and verify a ciphertext produced by Crypto_Box_Easy().
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy.json"/>
      [JSImport("sodium.crypto_box_easy", "blazorSodium")]
      public static partial byte[] Crypto_Box_Open_Easy(byte[] message, byte[] nonce, byte[] publicKey, byte[] privateKey);

      /// <summary>
      /// Decrypt and verify a ciphertext using a pre-calculated shared key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="sharedKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy_afternm.json"/>
      [JSImport("sodium.crypto_box_open_easy_afternm", "blazorSodium")]
      public static partial byte[] Crypto_Box_Open_Easy_After_NM(byte[] message, byte[] nonce, byte[] sharedKey);

      /// <summary>
      /// Derive an X25519 key pair from a seed.
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
   }
}
