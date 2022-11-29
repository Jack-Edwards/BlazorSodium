using BlazorSodium.Sodium.Models;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class SealedPublicKeyBox
   {
      /// <summary>
      /// Encrypts a message using only the recipient's public key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      public static byte[] Crypto_Box_Seal(byte[] message, byte[] publicKey)
         => Crypto_Box_Seal_Interop(message, publicKey);

      /// <summary>
      /// Encrypts a message using only the recipient's public key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      public static byte[] Crypto_Box_Seal(string message, byte[] publicKey)
         => Crypto_Box_Seal_Interop(message, publicKey);

      /// <summary>
      /// Decrypts a ciphertext using the recipient's key pair.
      /// </summary>
      /// <param name="ciphertext"></param>
      /// <param name="keyPair"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_seal_open.json"/>
      public static byte[] Crypto_Box_Seal_Open(byte[] ciphertext, X25519KeyPair keyPair)
         => Crypto_Box_Seal_Open_Interop(ciphertext, keyPair.PublicKey, keyPair.PrivateKey);
   }
}
