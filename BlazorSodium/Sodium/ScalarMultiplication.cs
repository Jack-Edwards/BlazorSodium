using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class ScalarMultiplication
   {
      /// <summary>
      /// Compute a shared secret given one user's private key and another user's public key.
      /// </summary>
      /// <param name="privateKey"></param>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_scalarmult.json"/>
      public static byte[] Crypto_ScalarMult(byte[] privateKey, byte[] publicKey)
         => Crypto_ScalarMult_Interop(privateKey, publicKey);

      /// <summary>
      /// Compute the public key for the provided private key.
      /// </summary>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_scalarmult_base.json"/>
      public static byte[] Crypto_ScalarMult_Base(byte[] privateKey)
         => Crypto_ScalarMult_Base_Interop(privateKey);
   }
}
