using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class Sodium
   {
      /// <summary>
      /// 
      /// </summary>
      /// <param name="constant"></param>
      /// <returns></returns>
      [JSImport("getSodiumConstant", "blazorSodium")]
      [return: JSMarshalAs<JSType.Number>]
      public static partial long GetConstantNumber(string constant);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="constant"></param>
      /// <returns></returns>
      [JSImport("getSodiumConstant", "blazorSodium")]
      public static partial string GetConstantString(string constant);
   }
}
