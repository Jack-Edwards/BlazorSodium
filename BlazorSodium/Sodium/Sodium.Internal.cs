using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class Sodium
   {
      /// <summary>
      /// Get a constant number from the sodium module.
      /// </summary>
      /// <param name="constant"></param>
      /// <returns></returns>
      [JSImport("getSodiumConstant", "blazorSodium")]
      [return: JSMarshalAs<JSType.Number>]
      public static partial long GetConstantNumber(string constant);

      /// <summary>
      /// Get a constant string from the sodium module.
      /// </summary>
      /// <param name="constant"></param>
      /// <returns></returns>
      [JSImport("getSodiumConstant", "blazorSodium")]
      public static partial string GetConstantString(string constant);

      /// <summary>
      /// Print the sodium module to the console.
      /// </summary>
      [JSImport("printSodium", "blazorSodium")]
      public static partial void PrintSodium();
   }
}
