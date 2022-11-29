using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class PasswordHash
   {
      /// <summary>
      /// Derive a key from the provided password and hashing parameters.
      /// </summary>
      /// <param name="keyLength"></param>
      /// <param name="password"></param>
      /// <param name="salt"></param>
      /// <param name="opsLimit"></param>
      /// <param name="memLimit"></param>
      /// <param name="algorithm"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_pwhash.json"/>
      public static byte[] Crypto_PwHash(uint keyLength, byte[] password, byte[] salt, uint opsLimit, uint memLimit, uint algorithm)
         => Crypto_PwHash_Interop(keyLength, password, salt, opsLimit, memLimit, algorithm);

      /// <summary>
      /// Derive a key from the provided password and hashing parameters.
      /// </summary>
      /// <param name="keyLength"></param>
      /// <param name="password"></param>
      /// <param name="salt"></param>
      /// <param name="opsLimit"></param>
      /// <param name="memLimit"></param>
      /// <param name="algorithm"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_pwhash.json"/>
      public static byte[] Crypto_PwHash(uint keyLength, string password, byte[] salt, uint opsLimit, uint memLimit, uint algorithm)
         => Crypto_PwHash_Interop(keyLength, password, salt, opsLimit, memLimit, algorithm);

      /// <summary>
      /// Generate an ASCII-encoded string which contains a hashed password,
      /// the automatically generated salt used to hash the password,
      /// and other parameters required to verify the password at a later time.
      /// </summary>
      /// <param name="password"></param>
      /// <param name="opsLimit"></param>
      /// <param name="memLimit"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_pwhash_str.json"/>
      public static string Crypto_PwHash_Str(string password, uint opsLimit, uint memLimit)
         => Crypto_PwHash_Str_Interop(password, opsLimit, memLimit);

      /// <summary>
      /// Check if a password verification string matches the provided opsLimit,
      /// memLimit, and current default algorithm.
      /// </summary>
      /// <param name="hashedPassword"></param>
      /// <param name="opsLimit"></param>
      /// <param name="memLimit"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_pwhash_str_needs_rehash.json"/>
      public static bool Crypto_PwHash_Str_Needs_Rehash(string hashedPassword, uint opsLimit, uint memLimit)
         => Crypto_PwHash_Str_Needs_Rehash_Interop(hashedPassword, opsLimit, memLimit);

      /// <summary>
      /// Verify the password verification string is valid for the provided password.
      /// </summary>
      /// <param name="hashedPassword"></param>
      /// <param name="password"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_pwhash_str_verify.json"/>
      public static bool Crypto_PwHash_Str_Verify(string hashedPassword, string password)
         => Crypto_PwHash_Str_Verify_Interop(hashedPassword, password);
   }
}
