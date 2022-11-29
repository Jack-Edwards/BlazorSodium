using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class RandomBytes
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="size"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_buf.json"/>
      [JSImport("sodium.randombytes_buf", "blazorSodium")]
      internal static partial byte[] RandomBytes_Buf_Interop([JSMarshalAs<JSType.Number>] long size);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="size"></param>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_buf_deterministic.json"/>
      [JSImport("sodium.randombytes_buf_deterministic", "blazorSodium")]
      internal static partial byte[] RandomBytes_Buf_Deterministic_Interop([JSMarshalAs<JSType.Number>] long size, byte[] seed);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_close.json"/>
      [JSImport("sodium.randombytes_close", "blazorSodium")]
      internal static partial int RandomBytes_Close_Interop();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_random.json"/>
      [JSImport("sodium.randombytes_random", "blazorSodium")]
      [return: JSMarshalAs<JSType.Number>]
      internal static partial long RandomBytes_Random_Interop();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_stir.json"/>
      [JSImport("sodium.randombytes_stir", "blazorSodium")]
      internal static partial void RandomBytes_Stir_Interop();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="upperBound"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_uniform.json"/>
      [JSImport("sodium.randombytes_uniform", "blazorSodium")]
      [return: JSMarshalAs<JSType.Number>]
      internal static partial long RandomBytes_Uniform_Interop([JSMarshalAs<JSType.Number>] long upperBound);
   }
}
