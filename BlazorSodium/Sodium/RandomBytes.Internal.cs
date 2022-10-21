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
      internal static partial byte[] RandomBytes_Buf_Internal([JSMarshalAs<JSType.Number>] long size);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="size"></param>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_buf_deterministic.json"/>
      [JSImport("sodium.randombytes_buf_deterministic", "blazorSodium")]
      internal static partial byte[] RandomBytes_Buf_Deterministic_Internal([JSMarshalAs<JSType.Number>] long size, byte[] seed);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_random.json"/>
      [JSImport("sodium.randombytes_random", "blazorSodium")]
      [return: JSMarshalAs<JSType.Number>]
      internal static partial long RandomBytes_Random_Internal();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="upperBound"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_uniform.json"/>
      [JSImport("sodium.randombytes_uniform", "blazorSodium")]
      [return: JSMarshalAs<JSType.Number>]
      internal static partial long RandomBytes_Uniform_Internal([JSMarshalAs<JSType.Number>] long upperBound);
   }
}
