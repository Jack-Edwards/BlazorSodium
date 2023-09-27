using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class ScalarMultiplication
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="privateKey"></param>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_scalarmult.json"/>
      [JSImport("sodium.crypto_scalarmult", "blazorSodium")]
      public static partial byte[] Crypto_ScalarMult_Interop(byte[] privateKey, byte[] publicKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_scalarmult_base.json"/>
      [JSImport("sodium.crypto_scalarmult_base", "blazorSodium")]
      public static partial byte[] Crypto_ScalarMult_Base_Interop(byte[] privateKey);

      /* Missing from the sodium module
      /// <summary>
      /// Compute a shared secret given one user's private key and another user's public key.
      /// </summary>
      /// <param name="privateKey"></param>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_scalarmult_ed25519.json"/>
      [JSImport("sodium.crypto_scalarmult_ed25519", "blazorSodium")]
      public static partial byte[] Crypto_ScalarMult_Ed25519(byte[] privateKey, byte[] publicKey);
      */

      
      /// <summary>
      /// Compute the public key for the provided private key.
      /// </summary>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_scalarmult_ed25519_base.json"/>
      [JSImport("sodium.crypto_scalarmult_ed25519_base", "blazorSodium")]
      public static partial byte[] Crypto_ScalarMult_Ed25519_Base_Interop(byte[] privateKey);
      

  
      /// <summary>
      /// Compute the public key for the provided private key.
      /// </summary>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_scalarmult_ed25519_base_noclamp.json"/>
      [JSImport("sodium.crypto_scalarmult_ed25519_base_noclamp", "blazorSodium")]
      public static partial byte[] Crypto_ScalarMult_Ed25519_Base_NoClamp_Interop(byte[] privateKey);
      

      /* Missing from the sodium module
      /// <summary>
      /// Compute a shared secret given one user's private key and another user's public key.
      /// </summary>
      /// <param name="privateKey"></param>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_scalarmult_ed25519_noclamp.json"/>
      [JSImport("sodium.crypto_scalarmult_ed25519_noclamp", "blazorSodium")]
      public static partial byte[] Crypto_ScalarMult_Ed25519_NoClamp(byte[] privateKey, byte[] publicKey);
      */

      /* Missing from the sodium module
      /// <summary>
      /// Compute a shared secret given one user's private key and another user's public key.
      /// </summary>
      /// <param name="scalar"></param>
      /// <param name="element"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_scalarmult_ristretto255.json"/>
      [JSImport("sodium.crypto_scalarmult_ristretto255", "blazorSodium")]
      public static partial byte[] Crypto_ScalarMult_Ristretto225(byte[] scalar, byte[] element);
      */

      /* Missing from the sodium module
      /// <summary>
      /// Compute the public key for the provided private key.
      /// </summary>
      /// <param name="scalar"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_scalarmult_ristretto255_base.json"/>
      [JSImport("sodium.crypto_scalarmult_ristretto255_base", "blazorSodium")]
      public static partial byte[] Crypto_ScalarMult_Ristretto225_Base(byte[] scalar);
      */
   }
}
