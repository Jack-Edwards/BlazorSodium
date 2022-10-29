using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class SealedPublicKeyBox
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name=""></param>
      /// <param name=""></param>
      /// <param name=""></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_seal_open.json"/>
      [JSImport("sodium.crypto_box_seal_open", "blazorSodium")]
      internal static partial byte[] Crypto_Box_Seal_Open_Internal(byte[] ciphertext, byte[] publicKey, byte[] privateKey);
   }
}
