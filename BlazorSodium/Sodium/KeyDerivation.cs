using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class KeyDerivation
   {
      /// <summary>
      /// Derive a subkey from the provided paremeters and master key.
      /// </summary>
      /// <param name="subkeyLength"></param>
      /// <param name="subkeyId"></param>
      /// <param name="context"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kdf_derive_from_key.json"/>
      public static byte[] KDF_Derive_From_Key(uint subkeyLength, uint subkeyId, string context, byte[] key)
         => KDF_Derive_From_Key_Internal(subkeyLength, subkeyId, context, key);

      /// <summary>
      /// Derive a subkey from the provided paremeters and master key.
      /// </summary>
      /// <param name="subkeyLength"></param>
      /// <param name="subkeyId"></param>
      /// <param name="context"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kdf_derive_from_key.json"/>
      public static byte[] KDF_Derive_From_Key(uint subkeyLength, uint subkeyId, string context, string key)
         => KDF_Derive_From_Key_Internal(subkeyLength, subkeyId, context, key);

      /// <summary>
      /// Create a master key.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kdf_keygen.json"/>
      [JSImport("sodium.crypto_kdf_keygen", "blazorSodium")]
      public static partial byte[] KDF_KeyGen();
   }
}
