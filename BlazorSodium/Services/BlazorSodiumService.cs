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
      private readonly IJSRuntime _jsRuntime;

      public BlazorSodiumService(IJSRuntime jsRuntime)
      {
         _jsRuntime = jsRuntime;
      }

      public async Task PasswordHashAsync()
      {
         byte[] hashedPassword = await BlazorSodium.Sodium.PasswordHash.PasswordHash.HashStringAsync(_jsRuntime, "foo");
         Console.WriteLine(Convert.ToBase64String(hashedPassword));
      }
   }
}
