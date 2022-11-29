using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class ShortHash
   {
      /// <summary>
      /// Compute a 64-bit hash for the provided message, using the provided key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash.json"/>
      public static byte[] Crypto_ShortHash(byte[] message, byte[] key)
         => Crypto_ShortHash_Interop(message, key);

      /// <summary>
      /// Compute a 64-bit hash for the provided message, using the provided key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash.json"/>
      public static byte[] Crypto_ShortHash(string message, byte[] key)
         => Crypto_ShortHash_Interop(message, key);

      /// <summary>
      /// Randomly generate a key suitable for short hashing.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash_keygen.json"/>
      public static byte[] Crypto_ShortHash_KeyGen()
         => Crypto_ShortHash_KeyGen_Interop();
   }
}
