using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class Authentication
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth.json"/>
      [JSImport("sodium.crypto_auth", "blazorSodium")]
      internal static partial byte[] Crypto_Auth_Interop(byte[] message, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth.json"/>
      [JSImport("sodium.crypto_auth", "blazorSodium")]
      internal static partial byte[] Crypto_Auth_Interop(string message, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth_keygen.json"/>
      [JSImport("sodium.crypto_auth_keygen", "blazorSodium")]
      internal static partial byte[] Crypto_Auth_KeyGen_Interop();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="authenticationTag"></param>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth_verify.json"/>
      [JSImport("sodium.crypto_auth_verify", "blazorSodium")]
      internal static partial bool Crypto_Auth_Verify_Interop(byte[] authenticationTag, byte[] message, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="authenticationTag"></param>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth_verify.json"/>
      [JSImport("sodium.crypto_auth_verify", "blazorSodium")]
      internal static partial bool Crypto_Auth_Verify_Interop(byte[] authenticationTag, string message, byte[] key);
   }
}
