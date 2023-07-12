using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class SealedPublicKeyBox
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      [JSImport("sodium.crypto_box_seal", "blazorSodium")]
      internal static partial byte[] Crypto_Box_Seal_Interop(byte[] message, byte[] publicKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicKey"></param>
      /// <returns></returns>
      [JSImport("sodium.crypto_box_seal", "blazorSodium")]
      internal static partial byte[] Crypto_Box_Seal_Interop(string message, byte[] publicKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="ciphertext"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_seal_open.json"/>
      [JSImport("sodium.crypto_box_seal_open", "blazorSodium")]
      internal static partial byte[] Crypto_Box_Seal_Open_Interop(byte[] ciphertext, byte[] publicKey, byte[] privateKey);
   }
}
