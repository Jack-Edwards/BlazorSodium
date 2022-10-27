using BlazorSodium.Sodium.Models;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   public static partial class PublicKeySignature
   {
      /// <summary>
      /// Create a signature with a copy of the original message attached.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign.json"/>
      [JSImport("sodium.crypto_sign", "blazorSodium")]
      public static partial byte[] Crypto_Sign(byte[] message, byte[] privateKey);

      /// <summary>
      /// Create a signature with attaching a copy of the original message.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_detached.json"/>
      [JSImport("sodium.crypto_sign_detached", "blazorSodium")]
      public static partial byte[] Crypto_Sign_Detached(byte[] message, byte[] privateKey);

      /// <summary>
      /// Convert an Ed25519 public key to an X25519 public key.
      /// </summary>
      /// <param name="ed25519PublicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_ed25519_pk_to_curve25519.json"/>
      [JSImport("sodium.crypto_sign_ed25519_pk_to_curve25519", "blazorSodium")]
      public static partial byte[] Crypto_Sign_Ed25519_PK_To_Curve25519(byte[] publicKey);

      /// <summary>
      /// Convert an Ed25519 private key to an X25519 private key.
      /// </summary>
      /// <param name="ed25519PrivateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_ed25519_sk_to_curve25519.json"/>
      [JSImport("sodium.crypto_sign_ed25519_sk_to_curve25519", "blazorSodium")]
      public static partial byte[] Crypto_Sign_Ed25519_SK_To_Curve25519(byte[] privateKey);

      /* Missing from the sodium module
      /// <summary>
      /// Extract the public key from an Ed25519 private key.
      /// </summary>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_ed25519_sk_to_pk.json"/>
      [JSImport("sodium.crypto_sign_ed25519_sk_to_pk", "blazorSodium")]
      public static partial byte[] Crypto_Sign_Ed25519_SK_To_PK(byte[] privateKey);
      */

      /* Missing from the sodium module
      /// <summary>
      /// Extract the seed from an Ed25519 private key.
      /// </summary>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_ed25519_sk_to_seed.json"/>
      [JSImport("sodium.crypto_sign_ed25519_sk_to_seed", "blazorSodium")]
      public static partial byte[] Crypto_Sign_Ed25519_SK_To_Seed(byte[] privateKey);
      */

      /// <summary>
      /// Compute a signature for the message previously supplied using Crypto_Sign_Update().
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_final_create.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_Sign_Final_Create(StateAddress stateAddress, byte[] privateKey)
         => Crypto_Sign_Final_Create_Internal(stateAddress.Value, privateKey);

      /// <summary>
      /// Verify the provided signature is valid for the message previously supplied using Crypto_Sign_Update().
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="signature"></param>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_final_verify.json"/>
      [SupportedOSPlatform("browser")]
      public static bool Crypto_Sign_Final_Verify(StateAddress stateAddress, byte[] signature, byte[] publicKey)
         => Crypto_Sign_Final_Verify_Internal(stateAddress.Value, signature, publicKey);

      /// <summary>
      /// Initialize the signature system for a multi-part message.
      /// This must be called before Crypto_Sign_Update().
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_init.json"/>
      [SupportedOSPlatform("browser")]
      public static StateAddress Crypto_Sign_Init()
      {
         int address = Crypto_Sign_Init_Internal();
         return new StateAddress(address);
      }

      /// <summary>
      /// Randomly generate an Ed25519 key pair.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_keypair.json"/>
      [SupportedOSPlatform("browser")]
      public static Ed25519KeyPair Crypto_Sign_KeyPair()
      {
         JSObject jsObject = Crypto_Sign_KeyPair_Internal();
         return Ed25519KeyPair.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Verify the signed message has a valid signature for the provided public key.
      /// </summary>
      /// <param name="signedMessage"></param>
      /// <param name="publicKey"></param>
      /// <returns>If the signature is valid, the message without the signature is returned.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_open.json"/>
      [JSImport("sodium.crypto_sign_open", "blazorSodium")]
      public static partial byte[] Crypto_Sign_Open(byte[] signedMessage, byte[] publicKey);

      /// <summary>
      /// Derive an Ed25519 key pair from a seed.
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_seed_keypair.json"/>
      [SupportedOSPlatform("browser")]
      public static Ed25519KeyPair Crypto_Sign_Seed_KeyPair(byte[] seed)
      {
         JSObject jsObject = Crypto_Sign_Seed_KeyPair_Internal(seed);
         return Ed25519KeyPair.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Add a new chunk to the message that will eventually be signed.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="messageChunk"></param>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_update.json"/>
      [SupportedOSPlatform("browser")]
      public static void Crypto_Sign_Update(StateAddress stateAddress, byte[] messageChunk)
         => Crypto_Sign_Update_Internal(stateAddress.Value, messageChunk);

      /// <summary>
      /// Verify the signed message has a valid signature for the provided public key.
      /// </summary>
      /// <param name="signature"></param>
      /// <param name="message"></param>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_sign_verify_detached.json"/>
      [JSImport("sodium.crypto_sign_verify_detached", "blazorSodium")]
      public static partial bool Crypto_Sign_Verify_Detached(byte[] signature, byte[] message, byte[] publicKey);
   }
}
