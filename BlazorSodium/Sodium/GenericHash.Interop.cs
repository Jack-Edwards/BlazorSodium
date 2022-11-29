using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class GenericHash
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="hashLength"></param>
      /// <param name="message"></param>
      /// <param name="key">Optional</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_generichash.json"/>
      [JSImport("sodium.crypto_generichash", "blazorSodium")]
      internal static partial byte[] Crypto_GenericHash_Interop([JSMarshalAs<JSType.Number>] long hashLength, byte[] message, byte[] key = null);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="hashLength"></param>
      /// <param name="message"></param>
      /// <param name="key">Optional</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_generichash.json"/>
      [JSImport("sodium.crypto_generichash", "blazorSodium")]
      internal static partial byte[] Crypto_GenericHash_Interop([JSMarshalAs<JSType.Number>] long hashLength, string message, byte[] key = null);

      /* Missing from the sodium module
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="subkeyLength"></param>
      /// <param name="key"></param>
      /// <param name="id"></param>
      /// <param name="context"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_generichash_blake2b_salt_personal.json"/>
      [JSImport("sodium.crypto_generichash_blake2b_salt_personal", "blazorSodium")]
      internal static partial byte[] Crypto_GenericHash_Blake2b_Salt_Personal_Interop([JSMarshalAs<JSType.Number>] long subkeyLength, byte[] key = null, byte[] id = null, byte[] context = null);
      */

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="hashLength"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_generichash_final.json"/>
      [JSImport("sodium.crypto_generichash_final", "blazorSodium")]
      internal static partial byte[] Crypto_GenericHash_Final_Interop(int stateAddress, [JSMarshalAs<JSType.Number>] long hashLength);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="key"></param>
      /// <param name="hashLength"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_generichash_init.json"/>
      [JSImport("sodium.crypto_generichash_init", "blazorSodium")]
      internal static partial int Crypto_GenericHash_Init_Interop(byte[] key, [JSMarshalAs<JSType.Number>] long hashLength);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_generichash_keygen.json"/>
      [JSImport("sodium.crypto_generichash_keygen", "blazorSodium")]
      internal static partial byte[] Crypto_GenericHash_KeyGen_Interop();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="messageChunk"></param>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_generichash_update.json"/>
      [JSImport("sodium.crypto_generichash_update", "blazorSodium")]
      internal static partial void Crypto_GenericHash_Update_Interop(int stateAddress, byte[] messageChunk);
   }
}
