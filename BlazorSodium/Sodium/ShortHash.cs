using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace BlazorSodium.Sodium
{
   public static partial class ShortHash
   {
      /// <summary>
      /// Compute a 64-bit hash for the provided message, using the provided key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash.json"/>
      [JSImport("sodium.crypto_shorthash", "blazorSodium")]
      public static partial byte[] Crypto_ShortHash(byte[] message, byte[] key);

      /// <summary>
      /// Compute a 64-bit hash for the provided message, using the provided key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash.json"/>
      [JSImport("sodium.crypto_shorthash", "blazorSodium")]
      public static partial byte[] Crypto_ShortHash(string message, byte[] key);

      public static bool Crypto_ShortHash_Test(byte[] hash, byte[] message, byte[] key)
      {
         Crypto_ShortHash_Test_Internal(hash, message, key);
         return true;
      }

      [JSImport("cryptoShortHash", "blazorSodium")]
      internal static partial void Crypto_ShortHash_Test_Internal([JSMarshalAs<JSType.MemoryView>] ArraySegment<byte> hashBuffer, [JSMarshalAs<JSType.MemoryView>] ArraySegment<byte> messageBuffer, [JSMarshalAs<JSType.MemoryView>] ArraySegment<byte> keyBuffer);

      public static void Crypto_ShortHash_Malloc_Test()
      {
         int hashAddress = Malloc((int)BYTES);
         int keyAddress = Malloc((int)KEY_BYTES);
         int messageAddress = Malloc(12);

         Crypto_ShortHash_Test_Internal(hashAddress, messageAddress, 12, 0, keyAddress);
         Console.WriteLine("it didn't break?");
         int value = GetValue(hashAddress, "i32");
         Console.WriteLine(value);
      }

      [JSImport("libsodium._malloc", "blazorSodium")]
      internal static partial int Malloc(int size);

      [JSImport("libsodium.getValue", "blazorSodium")]
      internal static partial int GetValue(int address, string type);

      public unsafe static bool Crypto_ShortHash_Test_Pointers(byte[] hash, byte[] message, byte[] key)
      {
         fixed (byte* hPtr = hash)
         fixed (byte* mPtr = message)
         fixed (byte* kPtr = key)
         {
            return Crypto_ShortHash_Test_Internal((IntPtr)hPtr, (IntPtr)mPtr, message.Length, 0, (IntPtr)kPtr) == 1;
         }
      }

      [JSImport("cryptoShortHashPointers", "blazorSodium")]
      internal static partial int Crypto_ShortHash_Test_Internal([JSMarshalAs<JSType.Number>] IntPtr hashAddress, [JSMarshalAs<JSType.Number>] IntPtr messageAddress, int messageLength, int something, [JSMarshalAs<JSType.Number>] IntPtr keyAddress);

      [JSImport("cryptoShortHashPointers", "blazorSodium")]
      internal static partial int Crypto_ShortHash_Test_Internal(int hashAddress, int messageAddress, int messageLength, int something, int keyAddress);

      /// <summary>
      /// Randomly generate a key suitable for short hashing.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash_keygen.json"/>
      [JSImport("sodium.crypto_shorthash_keygen", "blazorSodium")]
      public static partial byte[] Crypto_ShortHash_KeyGen();

      /* Missing from the sodium module
      /// <summary>
      /// Compute a 128-bit hash for the provided message, using the provided key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash_siphashx24.json"/>
      [JSImport("sodium.crypto_shorthash_siphashx24", "blazorSodium")]
      public static partial byte[] Crypto_ShortHash_SipHashX24(byte[] message, byte[] key);
      */

      /* Missing from the sodium module
      /// <summary>
      /// Compute a 128-bit hash for the provided message, using the provided key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_shorthash_siphashx24.json"/>
      [JSImport("sodium.crypto_shorthash_siphashx24", "blazorSodium")]
      public static partial byte[] Crypto_ShortHash_SipHashX24(string message, byte[] key);
      */
   }
}
