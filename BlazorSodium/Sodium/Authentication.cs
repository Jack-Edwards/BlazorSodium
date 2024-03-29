﻿using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class Authentication
   {
      /// <summary>
      /// Computes an authentication tag for the provided message, using the provided secret key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth.json"/>
      public static byte[] Crypto_Auth(byte[] message, byte[] key)
         => Crypto_Auth_Interop(message, key);

      /// <summary>
      /// Computes an authentication tag for the provided message, using the provided secret key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth.json"/>
      public static byte[] Crypto_Auth(string message, byte[] key)
         => Crypto_Auth_Interop(message, key);

      /// <summary>
      /// Randomly generate a secret key, suitable for other Authentication methods.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth_keygen.json"/>
      public static byte[] Crypto_Auth_KeyGen()
         => Crypto_Auth_KeyGen_Interop();

      /// <summary>
      /// Verify the provided tag is valid for the provided message and key.
      /// </summary>
      /// <param name="authenticationTag"></param>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth_verify.json"/>
      public static bool Crypto_Auth_Verify(byte[] authenticationTag, byte[] message, byte[] key)
         => Crypto_Auth_Verify_Interop(authenticationTag, message, key);

      /// <summary>
      /// Verify the provided tag is valid for the provided message and key.
      /// </summary>
      /// <param name="authenticationTag"></param>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_auth_verify.json"/>
      public static bool Crypto_Auth_Verify(byte[] authenticationTag, string message, byte[] key)
         => Crypto_Auth_Verify_Interop(authenticationTag, message, key);
   }
}
