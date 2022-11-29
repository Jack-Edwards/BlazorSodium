using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class Hash
   {
      /// <summary>
      /// Hash the provided message using a SHA-2 hashing function.
      /// </summary>
      /// <param name="message"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_hash.json"/>
      public static byte[] Crypto_Hash(byte[] message)
         => Crypto_Hash_Interop(message);

      /// <summary>
      /// Hash the provided message using a SHA-2 hashing function.
      /// </summary>
      /// <param name="message"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_hash.json"/>
      public static byte[] Crypto_Hash(string message)
         => Crypto_Hash_Interop(message);

      /* Missing from the sodium module:
       * - crypto_hash_sha256
       * - crypto_hash_sha256_final
       * - crypto_hash_sha256_init
       * - crypto_hash_sha256_update
       * - crypto_hash_sha512
       * - crypto_hash_sha512_final
       * - crypto_hash_sha512_init
       * - crypto_hash_sha512_update
      */
   }
}
