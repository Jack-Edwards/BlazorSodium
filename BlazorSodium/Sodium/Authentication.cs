using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class Authentication
   {
      /// <summary>
      /// Computes an authentication tag for the provided message, using the provided secret key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth.json"/>
      [JSImport("sodium.crypto_auth", "blazorSodium")]
      public static partial byte[] Crypto_Auth(byte[] message, byte[] key);

      /// <summary>
      /// Computes an authentication tag for the provided message, using the provided secret key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth.json"/>
      [JSImport("sodium.crypto_auth", "blazorSodium")]
      public static partial byte[] Crypto_Auth(string message, byte[] key);

      /// <summary>
      /// Randomly generate a secret key, suitable for other Authentication methods.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth_keygen.json"/>
      [JSImport("sodium.crypto_auth_keygen", "blazorSodium")]
      public static partial byte[] Crypto_Auth_KeyGen();

      /// <summary>
      /// Verify the provided tag is valid for the provided message and key.
      /// </summary>
      /// <param name="authenticationTag"></param>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth_verify.json"/>
      [JSImport("sodium.crypto_auth_verify", "blazorSodium")]
      public static partial bool Crypto_Auth_Verify(byte[] authenticationTag, byte[] message, byte[] key);

      /// <summary>
      /// Verify the provided tag is valid for the provided message and key.
      /// </summary>
      /// <param name="authenticationTag"></param>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth_verify.json"/>
      [JSImport("sodium.crypto_auth_verify", "blazorSodium")]
      public static partial bool Crypto_Auth_Verify(byte[] authenticationTag, string message, byte[] key);
   }
}
