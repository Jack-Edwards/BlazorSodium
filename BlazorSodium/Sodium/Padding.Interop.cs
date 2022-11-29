using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class Padding
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="data"></param>
      /// <param name="blockSize"></param>
      /// <returns></returns>
      [JSImport("sodium.pad", "blazorSodium")]
      internal static partial byte[] Pad_Interop(byte[] data, [JSMarshalAs<JSType.Number>] long blockSize);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="data"></param>
      /// <param name="blockSize"></param>
      /// <returns></returns>
      [JSImport("sodium.unpad", "blazorSodium")]
      internal static partial byte[] Unpad_Interop(byte[] data, [JSMarshalAs<JSType.Number>] long blockSize);
   }
}
