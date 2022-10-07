using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Demo.Shared
{
   public partial class BlazorSodiumComponent
   {
      protected override async Task OnInitializedAsync()
      {
         await JSHost.ImportAsync("blazorSodium", "../_content/BlazorSodium/blazorSodium.bundle.js");
         //Interop.Test();
         await Interop.InitializeAsync();
      }

      public partial class Interop
      {
         static Interop()
         {
         }

         [JSImport("sodium.ready", "blazorSodium")]
         public static partial Task InitializeAsync();

         [JSImport("test", "blazorSodium")]
         public static partial void Test();
      }
   }
}
