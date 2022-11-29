using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class PasswordHash
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="keyLength"></param>
      /// <param name="password"></param>
      /// <param name="salt"></param>
      /// <param name="opsLimit"></param>
      /// <param name="memLimit"></param>
      /// <param name="algorithm"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_pwhash.json"/>
      [JSImport("sodium.crypto_pwhash", "blazorSodium")]
      internal static partial byte[] Crypto_PwHash_Interop([JSMarshalAs<JSType.Number>] long keyLength, byte[] password, byte[] salt, [JSMarshalAs<JSType.Number>] long opsLimit, [JSMarshalAs<JSType.Number>] long memLimit, [JSMarshalAs<JSType.Number>] long algorithm);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="keyLength"></param>
      /// <param name="password"></param>
      /// <param name="salt"></param>
      /// <param name="opsLimit"></param>
      /// <param name="memLimit"></param>
      /// <param name="algorithm"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_pwhash.json"/>
      [JSImport("sodium.crypto_pwhash", "blazorSodium")]
      internal static partial byte[] Crypto_PwHash_Interop([JSMarshalAs<JSType.Number>] long keyLength, string password, byte[] salt, [JSMarshalAs<JSType.Number>] long opsLimit, [JSMarshalAs<JSType.Number>] long memLimit, [JSMarshalAs<JSType.Number>] long algorithm);

      /* Missing from the sodium module
      [JSImport("sodium.crypto_pwhash_scryptsalsa208sha256", "blazorSodium)]
      internal static partial byte[] Crypto_PwHash_ScryptSalsa208SHA256();
      */

      /* Missing from the sodium module
      [JSImport("sodium.crypto_pwhash_scryptsalsa208sha256_ll", "blazorSodium)]
      internal static partial byte[] Crypto_PwHash_ScryptSalsa208SHA256_LL();
      */

      /* Missing from the sodium module
      [JSImport("sodium.crypto_pwhash_scryptsalsa208sha256_str", "blazorSodium)]
      internal static partial byte[] Crypto_PwHash_ScryptSalsa208SHA256_Str();
      */

      /* Missing from the sodium module
      [JSImport("sodium.crypto_pwhash_scryptsalsa208sha256_str_verify", "blazorSodium)]
      internal static partial byte[] Crypto_PwHash_ScryptSalsa208SHA256_Str_Verify();
      */

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="password"></param>
      /// <param name="opsLimit"></param>
      /// <param name="memLimit"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_pwhash_str.json"/>
      [JSImport("sodium.crypto_pwhash_str", "blazorSodium")]
      internal static partial string Crypto_PwHash_Str_Interop(string password, [JSMarshalAs<JSType.Number>] long opsLimit, [JSMarshalAs<JSType.Number>] long memLimit);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="hashedPassword"></param>
      /// <param name="opsLimit"></param>
      /// <param name="memLimit"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_pwhash_str_needs_rehash.json"/>
      [JSImport("sodium.crypto_pwhash_str_needs_rehash", "blazorSodium")]
      internal static partial bool Crypto_PwHash_Str_Needs_Rehash_Interop(string hashedPassword, [JSMarshalAs<JSType.Number>] long opsLimit, [JSMarshalAs<JSType.Number>] long memLimit);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="hashedPassword"></param>
      /// <param name="password"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_pwhash_str_verify.json"/>
      [JSImport("sodium.crypto_pwhash_str_verify", "blazorSodium")]
      internal static partial bool Crypto_PwHash_Str_Verify_Interop(string hashedPassword, string password);
   }
}
