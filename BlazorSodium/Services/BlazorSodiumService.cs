using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorSodium.Services
{
   public interface IBlazorSodiumService
   {
      Task InitializeAsync();
   }

   public class BlazorSodiumService : IBlazorSodiumService
   {
      private readonly IJSRuntime _jsRuntime;

      public BlazorSodiumService(IJSRuntime jsRuntime)
      {
         _jsRuntime = jsRuntime;
      }

      public async Task InitializeAsync()
      {
         //await _jsRuntime.InvokeVoidAsync("eval", new object[] { _bootstrapperScript });
      }
   }
}
