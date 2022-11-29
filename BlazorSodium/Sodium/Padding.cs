using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class Padding
   {
      public static byte[] Pad(byte[] data, uint blockSize)
      {
         return Pad_Internal(data, blockSize);
      }

      public static byte[] Unpad(byte[] data, uint blockSize)
      {
         return Unpad_Internal(data, blockSize);
      }
   }
}
