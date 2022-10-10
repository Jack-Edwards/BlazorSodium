using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class Sodium
   {
      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/sodium_version_string.json"/>
      [JSImport("sodium.sodium_version_string", "blazorSodium")]
      public static partial string Sodium_Version_String();
   }
}
