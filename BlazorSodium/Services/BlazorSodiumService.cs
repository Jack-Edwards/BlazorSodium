using System.Runtime.InteropServices.JavaScript;
using System.Threading.Tasks;

namespace BlazorSodium.Services
{
   public interface IBlazorSodiumService
   {
      Task InitializeAsync();
   }

   public partial class BlazorSodiumService : IBlazorSodiumService
   {
      public BlazorSodiumService()
      { }

      public async Task InitializeAsync()
      {
         await JSHost.ImportAsync("blazorSodium", "../_content/BlazorSodium/blazorSodium.bundle.js");
         await PrivateInitializeAsync();
      }

      [JSImport("blazorSodiumInit", "blazorSodium")]
      private static partial Task PrivateInitializeAsync();
   }
}
