using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class KeyDerivation
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="subkeyLength"></param>
      /// <param name="subkeyId"></param>
      /// <param name="context"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kdf_derive_from_key.json"/>
      [JSImport("sodium.crypto_kdf_derive_from_key", "blazorSodium")]
      public static partial byte[] KDF_Derive_From_Key_Internal([JSMarshalAs<JSType.Number>] long subkeyLength, [JSMarshalAs<JSType.Number>] long subkeyId, string context, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="subkeyLength"></param>
      /// <param name="subkeyId"></param>
      /// <param name="context"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kdf_derive_from_key.json"/>
      [JSImport("sodium.crypto_kdf_derive_from_key", "blazorSodium")]
      public static partial byte[] KDF_Derive_From_Key_Internal([JSMarshalAs<JSType.Number>] long subkeyLength, [JSMarshalAs<JSType.Number>] long subkeyId, string context, string key);
   }
}
