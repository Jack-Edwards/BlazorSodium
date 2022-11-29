using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class Padding
    {
      [JSImport("sodium.pad", "blazorSodium")]
      internal static partial byte[] Pad_Internal(byte[] data, [JSMarshalAs<JSType.Number>] long blockSize);

      [JSImport("sodium.unpad", "blazorSodium")]
      internal static partial byte[] Unpad_Internal(byte[] data, [JSMarshalAs<JSType.Number>] long blockSize);
   }
}
