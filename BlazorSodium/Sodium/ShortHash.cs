using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class ShortHash
   {
      /// <summary>
      /// Compute a 64-bit hash for the provided message, using the provided key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash.json"/>
      [JSImport("sodium.crypto_shorthash", "blazorSodium")]
      public static partial byte[] Crypto_ShortHash(byte[] message, byte[] key);

      /// <summary>
      /// Compute a 64-bit hash for the provided message, using the provided key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash.json"/>
      [JSImport("sodium.crypto_shorthash", "blazorSodium")]
      public static partial byte[] Crypto_ShortHash(string message, byte[] key);

      /// <summary>
      /// Randomly generate a key suitable for short hashing.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash_keygen.json"/>
      [JSImport("sodium.crypto_shorthash_keygen", "blazorSodium")]
      public static partial byte[] Crypto_ShortHash_KeyGen();

      /* Missing from the sodium module
      /// <summary>
      /// Compute a 128-bit hash for the provided message, using the provided key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash_siphashx24.json"/>
      [JSImport("sodium.crypto_shorthash_siphashx24", "blazorSodium")]
      public static partial byte[] Crypto_ShortHash_SipHashX24(byte[] message, byte[] key);
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
      public static partial byte[] Crypto_ShortHash_SipHashX24(string message, byte[] key);
      */
   }
}
