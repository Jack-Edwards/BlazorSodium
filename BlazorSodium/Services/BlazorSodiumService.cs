using BlazorSodium.Sodium.PasswordHash;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BlazorSodium.Services
{
   public interface IBlazorSodiumService
   {
      Task PasswordHashAsync();
   }

   public class BlazorSodiumService : IBlazorSodiumService
   {
      private readonly IJSInProcessRuntime _inProcessRuntime;
      private readonly IJSRuntime _standardJsRuntime;

      public BlazorSodiumService(IJSRuntime jsRuntime)
      {
         _inProcessRuntime = (IJSInProcessRuntime)jsRuntime;
         _standardJsRuntime = jsRuntime;
      }

      public async Task PasswordHashAsync()
      {
         byte[] hashedPassword = await BlazorSodium.Sodium.PasswordHash.PasswordHash.HashStringAsync(_inProcessRuntime, _standardJsRuntime, "foo");
         Console.WriteLine(Convert.ToBase64String(hashedPassword));
      }
   }
}
