using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class RandomBytes
   {
      /// <summary>
      /// Generate an unpredictable sequence of bytes of the provided size.
      /// </summary>
      /// <param name="size"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_buf.json"/>
      public static byte[] RandomBytes_Buf(uint size)
         => RandomBytes_Buf_Interop(size);

      /// <summary>
      /// Generate a deterministic sequence of bytes of the provided size with the provided seed.
      /// </summary>
      /// <param name="size"></param>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_buf_deterministic.json"/>
      public static byte[] RandomBytes_Buf_Deterministic(uint size, byte[] seed)
         => RandomBytes_Buf_Deterministic_Interop(size, seed);

      /// <summary>
      /// Deallocates the global resources used by the pseudo-random number generator.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_close.json"/>
      public static int RandomBytes_Close()
         => RandomBytes_Close_Interop();

      /// <summary>
      /// Return an unpredictable value between 0 and 0xffffffff (inclusive).
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_random.json"/>
      public static uint RandomBytes_Random()
         => (uint)RandomBytes_Random_Interop();

      /// <summary>
      /// Reseed the psudeo-ranndom number generator, if supported.
      /// </summary>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_stir.json"/>
      public static void RandomBytes_Stir()
         => RandomBytes_Stir_Interop();

      /// <summary>
      /// Return an unpredictable value between 0 and the provided 'upperBound' (exclusive).
      /// </summary>
      /// <param name="upperBound"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_uniform.json"/>
      public static uint RandomBytes_Uniform(uint upperBound)
         => (uint)RandomBytes_Uniform_Interop(upperBound);
   }
}
