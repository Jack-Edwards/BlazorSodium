using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class Sodium
   {
      /// <summary>
      /// Print the "sodium" module to the browser console.
      /// </summary>
      public static void PrintSodium()
         => PrintSodium_Interop();

      /// <summary>
      /// Get the current version of the underlying libsodium.js package.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/sodium_version_string.json"/>
      public static string Sodium_Version_String()
         => Sodium_Version_String_Interop();
   }
}
