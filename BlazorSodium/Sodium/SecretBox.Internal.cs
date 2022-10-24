using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class SecretBox
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretbox_detached.json"/>
      [JSImport("sodium.crypto_secretbox_detached", "blazorSodium")]
      internal static partial JSObject Crypto_SecretBox_Detached_Internal(byte[] message, byte[] nonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretbox_detached.json"/>
      [JSImport("sodium.crypto_secretbox_detached", "blazorSodium")]
      internal static partial JSObject Crypto_SecretBox_Detached_Internal(string message, byte[] nonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretbox_easy.json"/>
      [JSImport("sodium.crypto_secretbox_easy", "blazorSodium")]
      internal static partial byte[] Crypto_SecretBox_Easy_Internal(byte[] message, byte[] nonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="cipher"></param>
      /// <param name="mac"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      [JSImport("sodium.crypto_secretbox_open_detached", "blazorSodium")]
      internal static partial byte[] Crypto_SecretBox_Open_Detached_Internal(byte[] cipher, byte[] mac, byte[] nonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretbox_easy.json"/>
      [JSImport("sodium.crypto_secretbox_easy", "blazorSodium")]
      internal static partial byte[] Crypto_SecretBox_Easy_Internal(string message, byte[] nonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="cipher"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretbox_open_easy.json"/>
      [JSImport("sodium.crypto_secretbox_open_easy", "blazorSodium")]
      internal static partial byte[] Crypto_SecretBox_Open_Easy_Internal(byte[] cipher, byte[] nonce, byte[] key);
   }
}
