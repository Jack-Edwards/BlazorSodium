using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class PublicKeySignature
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign.json"/>
      [JSImport("sodium.crypto_sign", "blazorSodium")]
      internal static partial byte[] Crypto_Sign_Interop(byte[] message, byte[] privateKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_detached.json"/>
      [JSImport("sodium.crypto_sign_detached", "blazorSodium")]
      internal static partial byte[] Crypto_Sign_Detached_Interop(byte[] message, byte[] privateKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_ed25519_pk_to_curve25519.json"/>
      [JSImport("sodium.crypto_sign_ed25519_pk_to_curve25519", "blazorSodium")]
      internal static partial byte[] Crypto_Sign_Ed25519_PK_To_Curve25519_Interop(byte[] publicKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_ed25519_sk_to_curve25519.json"/>
      [JSImport("sodium.crypto_sign_ed25519_sk_to_curve25519", "blazorSodium")]
      internal static partial byte[] Crypto_Sign_Ed25519_SK_To_Curve25519_Interop(byte[] privateKey);

      /* Missing from the sodium module
      /// <summary>
      /// Extract the public key from an Ed25519 private key.
      /// </summary>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_ed25519_sk_to_pk.json"/>
      [JSImport("sodium.crypto_sign_ed25519_sk_to_pk", "blazorSodium")]
      internal static partial byte[] Crypto_Sign_Ed25519_SK_To_PK_Interop(byte[] privateKey);
      */

      /* Missing from the sodium module
      /// <summary>
      /// Extract the seed from an Ed25519 private key.
      /// </summary>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_ed25519_sk_to_seed.json"/>
      [JSImport("sodium.crypto_sign_ed25519_sk_to_seed", "blazorSodium")]
      internal static partial byte[] Crypto_Sign_Ed25519_SK_To_Seed_Interop(byte[] privateKey);
      */

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_final_create.json"/>
      [JSImport("sodium.crypto_sign_final_create", "blazorSodium")]
      internal static partial byte[] Crypto_Sign_Final_Create_Interop([JSMarshalAs<JSType.Number>] long stateAddress, byte[] privateKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="signature"></param>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_final_verify.json"/>
      [JSImport("sodium.crypto_sign_final_verify", "blazorSodium")]
      internal static partial bool Crypto_Sign_Final_Verify_Interop([JSMarshalAs<JSType.Number>] long stateAddress, byte[] signature, byte[] publicKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_init.json"/>
      /// <remarks>
      /// Switching the return type to 'long' and applying a [return: JSMarshalAs&lt;JSType.Number&gt;]
      /// attribute does not work any better than simply returning an 'int'.
      /// 
      /// A 'System.Runtime.InteropServices.JavaScript.JSException' exception is thrown when
      /// the return value reaches or exceeds 2,147,483,647. The exception message is '[object Object]'.
      /// </remarks>
      [JSImport("sodium.crypto_sign_init", "blazorSodium")]
      internal static partial int Crypto_Sign_Init_Interop();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_keypair.json"/>
      [JSImport("sodium.crypto_sign_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Sign_KeyPair_Interop();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="signedMessage"></param>
      /// <param name="publicKey"></param>
      /// <returns>If the signature is valid, the message without the signature is returned.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_open.json"/>
      [JSImport("sodium.crypto_sign_open", "blazorSodium")]
      internal static partial byte[] Crypto_Sign_Open_Interop(byte[] signedMessage, byte[] publicKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_seed_keypair.json"/>
      [JSImport("sodium.crypto_sign_seed_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_Sign_Seed_KeyPair_Interop(byte[] seed);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="messageChunk"></param>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_update.json"/>
      [JSImport("sodium.crypto_sign_update", "blazorSodium")]
      internal static partial void Crypto_Sign_Update_Interop([JSMarshalAs<JSType.Number>] long stateAddress, byte[] messageChunk);

      /// <summary>
      /// Verify the signed message has a valid signature for the provided public key.
      /// </summary>
      /// <param name="signature"></param>
      /// <param name="message"></param>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_verify_detached.json"/>
      [JSImport("sodium.crypto_sign_verify_detached", "blazorSodium")]
      internal static partial bool Crypto_Sign_Verify_Detached_Interop(byte[] signature, byte[] message, byte[] publicKey);
   }
}
