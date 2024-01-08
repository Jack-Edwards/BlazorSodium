using System;
using System.Runtime.InteropServices.JavaScript;
using System.Threading.Tasks;

namespace BlazorSodium.Services
{
   public interface IBlazorSodiumService
   {
      /// <summary>
      /// Import the blazorSodium.bundle.js file which allows BlazorSodium to invoke libsodium.js.
      /// </summary>
      /// <returns></returns>
      Task InitializeAsync();
   }

   public partial class BlazorSodiumService : IBlazorSodiumService
   {
      public async Task InitializeAsync()
      {
         if (OperatingSystem.IsBrowser())
         {
            await JSHost.ImportAsync("blazorSodium", "../_content/BlazorSodium/blazorSodium.bundle.js");
            await PrivateInitializeAsync();
         }
      }

      [JSImport("init", "blazorSodium")]
      private static partial Task PrivateInitializeAsync();
   }
}
