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
      internal static partial long GetConstantNumber_Interop(string constant);

      /// <summary>
      /// Get a constant string from the sodium module.
      /// </summary>
      /// <param name="constant"></param>
      /// <returns></returns>
      [JSImport("getSodiumConstant", "blazorSodium")]
      internal static partial string GetConstantString_Interop(string constant);

      /// <summary>
      /// Print the sodium module to the console.
      /// </summary>
      [JSImport("printSodium", "blazorSodium")]
      internal static partial void PrintSodium_Interop();

      /// <summary>
      /// Get the current version of the underlying libsodium.js package.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/sodium_version_string.json"/>
      [JSImport("sodium.sodium_version_string", "blazorSodium")]
      internal static partial string Sodium_Version_String_Interop();
   }
}
