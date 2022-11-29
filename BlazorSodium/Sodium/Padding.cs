using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class Padding
   {
      /// <summary>
      /// Return a padded copy of the provided data.
      /// </summary>
      /// <param name="data"></param>
      /// <param name="blockSize"></param>
      /// <returns></returns>
      public static byte[] Pad(byte[] data, uint blockSize)
         => Pad_Interop(data, blockSize);

      /// <summary>
      /// Remove padding from the end of the provided data.
      /// </summary>
      /// <param name="data"></param>
      /// <param name="blockSize"></param>
      /// <returns></returns>
      public static byte[] Unpad(byte[] data, uint blockSize)
         => Unpad_Interop(data, blockSize);
   }
}
