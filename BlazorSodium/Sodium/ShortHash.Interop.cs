using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class ShortHash
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash.json"/>
      [JSImport("sodium.crypto_shorthash", "blazorSodium")]
      internal static partial byte[] Crypto_ShortHash_Interop(byte[] message, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash.json"/>
      [JSImport("sodium.crypto_shorthash", "blazorSodium")]
      internal static partial byte[] Crypto_ShortHash_Interop(string message, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash_keygen.json"/>
      [JSImport("sodium.crypto_shorthash_keygen", "blazorSodium")]
      internal static partial byte[] Crypto_ShortHash_KeyGen_Interop();

      /* Missing from the sodium module
      /// <summary>
      /// Compute a 128-bit hash for the provided message, using the provided key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash_siphashx24.json"/>
      [JSImport("sodium.crypto_shorthash_siphashx24", "blazorSodium")]
      internal static partial byte[] Crypto_ShortHash_SipHashX24_Interop(byte[] message, byte[] key);
      */

      /* Missing from the sodium module
      /// <summary>
      /// Compute a 128-bit hash for the provided message, using the provided key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash_siphashx24.json"/>
      [JSImport("sodium.crypto_shorthash_siphashx24", "blazorSodium")]
      internal static partial byte[] Crypto_ShortHash_SipHashX24_Interop(string message, byte[] key);
      */
   }
}
