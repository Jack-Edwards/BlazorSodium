using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class PublicKeySignature
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_final_create.json"/>
      [JSImport("sodium.crypto_sign_final_create", "blazorSodium")]
      internal static partial byte[] Crypto_Sign_Final_Create_Internal([JSMarshalAs<JSType.Number>] long stateAddress, byte[] privateKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="signature"></param>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_final_verify.json"/>
      [JSImport("sodium.crypto_sign_final_verify", "blazorSodium")]
      internal static partial bool Crypto_Sign_Final_Verify_Internal([JSMarshalAs<JSType.Number>] long stateAddress, byte[] signature, byte[] publicKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_init.json"/>
      /// <remarks>
      /// Switching the return type to 'long' and applying a [return: JSMarshalAs<JSType.Number>]
      /// attribute does not work any better than simply returning an 'int'.
      /// 
      /// A 'System.Runtime.InteropServices.JavaScript.JSException' exception is thrown when
      /// the return value reaches or exceeds 2,147,483,647. The exception message is '[object Object]'.
      /// </remarks>
      [JSImport("sodium.crypto_sign_init", "blazorSodium")]
      internal static partial int Crypto_Sign_Init_Internal();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_keypair.json"/>
      [JSImport("sodium.crypto_sign_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Sign_KeyPair_Internal();


      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_seed_keypair.json"/>
      [JSImport("sodium.crypto_sign_seed_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Sign_Seed_KeyPair_Internal(byte[] seed);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="messageChunk"></param>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_update.json"/>
      [JSImport("sodium.crypto_sign_update", "blazorSodium")]
      internal static partial void Crypto_Sign_Update_Internal([JSMarshalAs<JSType.Number>] long stateAddress, byte[] messageChunk);
   }
}
