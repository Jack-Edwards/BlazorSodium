using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   public static partial class RandomBytes
   {
      /// <summary>
      /// Generate an unpredictable sequence of bytes of the provided size.
      /// </summary>
      /// <param name="size"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_buf.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] RandomBytes_Buf(uint size)
         => RandomBytes_Buf_Internal(size);

      /// <summary>
      /// Generate a deterministic sequence of bytes of the provided size with the provided seed.
      /// </summary>
      /// <param name="size"></param>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_buf_deterministic.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] RandomBytes_Buf_Deterministic(uint size, byte[] seed)
         => RandomBytes_Buf_Deterministic_Internal(size, seed);

      /// <summary>
      /// Deallocates the global resources used by the pseudo-random number generator.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_close.json"/>
      [JSImport("sodium.randombytes_close", "blazorSodium")]
      public static partial int RandomBytes_Close();

      /// <summary>
      /// Return an unpredictable value between 0 and 0xffffffff (inclusive).
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_random.json"/>
      [SupportedOSPlatform("browser")]
      public static uint RandomBytes_Random()
         => (uint)RandomBytes_Random_Internal();

      /// <summary>
      /// Reseed the psudeo-ranndom number generator, if supported.
      /// </summary>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_stir.json"/>
      [JSImport("sodium.randombytes_stir", "blazorSodium")]
      public static partial void RandomBytes_Stir();

      /// <summary>
      /// Return an unpredictable value between 0 and the provided 'upperBound' (exclusive).
      /// </summary>
      /// <param name="upperBound"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_uniform.json"/>
      [SupportedOSPlatform("browser")]
      public static uint RandomBytes_Uniform(uint upperBound)
         => (uint)RandomBytes_Uniform_Internal(upperBound);
   }
}
