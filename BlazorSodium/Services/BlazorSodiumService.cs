using BlazorSodium.Sodium;
using Microsoft.JSInterop;
using System;
using System.Runtime.InteropServices.JavaScript;
using System.Security;
using System.Threading.Tasks;

namespace BlazorSodium.Services
{
   public interface IBlazorSodiumService
   {
      Task InitializeAsync();
   }

   public partial class BlazorSodiumService : IBlazorSodiumService
   {
      public BlazorSodiumService(IJSRuntime jsRuntime)
      {
         IJSInProcessRuntime inProcessRuntime = (IJSInProcessRuntime)jsRuntime;

         //PasswordHash = new PasswordHash(inProcessRuntime);
      }

      public async Task InitializeAsync()
      {

         await InitializeInternalAsync();
      }

      [JSImport("sodium.ready", "blazorSodium")]
      internal static partial Task InitializeInternalAsync();
   }
}
