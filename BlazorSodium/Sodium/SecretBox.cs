using BlazorSodium.Sodium.Models;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class SecretBox
   {
      /// <summary>
      /// Encrypt a message using the provided key and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <param name="nonce"></param>
      /// <returns>An object containing the authentication tag and encrypted message.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretbox_detached.json"/>
      public static SecretBoxDetached Crypto_SecretBox_Detached(byte[] message, byte[] key, byte[] nonce)
      {
         JSObject jsObject = Crypto_SecretBox_Detached_Interop(message, nonce, key);
         return SecretBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypt a message using the provided key and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <param name="nonce"></param>
      /// <returns>An object containing the authentication tag and encrypted message.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretbox_detached.json"/>
      public static SecretBoxDetached Crypto_SecretBox_Detached(string message, byte[] key, byte[] nonce)
      {
         JSObject jsObject = Crypto_SecretBox_Detached_Interop(message, nonce, key);
         return SecretBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypt a message using the provided key and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <param name="nonce"></param>
      /// <returns>A sequence of bytes containing the authentication tag and encrypted message.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretbox_easy.json"/>
      public static byte[] Crypto_SecretBox_Easy(byte[] message, byte[] key, byte[] nonce)
         => Crypto_SecretBox_Easy_Interop(message, nonce, key);

      /// <summary>
      /// Encrypt a message using the provided key and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <param name="nonce"></param>
      /// <returns>A sequence of bytes containing the authentication tag and encrypted message.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretbox_easy.json"/>
      public static byte[] Crypto_SecretBox_Easy(string message, byte[] key, byte[] nonce)
         => Crypto_SecretBox_Easy_Interop(message, nonce, key);

      /// <summary>
      /// Randomly generate a key suitable for SecretBox encryption.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretbox_keygen.json"/>
      public static byte[] Crypto_SecretBox_KeyGen()
         => Crypto_SecretBox_KeyGen_Interop();

      /// <summary>
      /// Verifies and decrypts the provided detached box using the provided key and nonce.
      /// </summary>
      /// <param name="detachedBox"></param>
      /// <param name="key"></param>
      /// <param name="nonce"></param>
      /// <returns></returns>
      public static byte[] Crypto_SecretBox_Open_Detached(SecretBoxDetached detachedBox, byte[] key, byte[] nonce)
         => Crypto_SecretBox_Open_Detached_Interop(detachedBox.Cipher, detachedBox.MessageAuthenticationCode, nonce, key);

      /// <summary>
      /// Verifies and decrypts the provided ciphertext using the provided key and nonce.
      /// </summary>
      /// <param name="cipher"></param>
      /// <param name="key"></param>
      /// <param name="nonce"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretbox_open_easy.json"/>
      public static byte[] Crypto_SecretBox_Open_Easy(byte[] cipher, byte[] key, byte[] nonce)
         => Crypto_SecretBox_Open_Easy_Interop(cipher, nonce, key);
   }
}
