using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class RandomBytes
   {
      /// <summary>
      /// 
      /// </summary>
      /// <param name="length"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_buf.json"/>
      [JSImport("sodium.randombytes_buf", "blazorSodium")]
      public static partial byte[] RandomBytes_Buf(int length);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="length"></param>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_buf_deterministic.json"/>
      [JSImport("sodium.randombytes_buf_deterministic", "blazorSodium")]
      public static partial byte[] RandomBytes_Buf_Deterministic(int length, byte[] seed);

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_close.json"/>
      [JSImport("sodium.randombytes_close", "blazorSodium")]
      public static partial int RandomBytes_Close();

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_random.json"/>
      [JSImport("sodium.randombytes_random", "blazorSodium")]
      public static partial int RandomBytes_Random();

      /* TODO
      /// <summary>
      /// 
      /// </summary>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_set_implementation.json"/>
      [JSImport("sodium.randombytes_set_implementation", "blazorSodium")]
      public static partial void RandomBytes_Set_Implementation();
      */

      /// <summary>
      /// 
      /// </summary>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_stir.json"/>
      [JSImport("sodium.randombytes_stir", "blazorSodium")]
      public static partial void RandomBytes_Stir();

      /// <summary>
      /// 
      /// </summary>
      /// <param name="upperBound"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_uniform.json"/>
      [JSImport("sodium.randombytes_uniform", "blazorSodium")]
      public static partial int RandomBytes_Uniform(int upperBound);
   }
}
