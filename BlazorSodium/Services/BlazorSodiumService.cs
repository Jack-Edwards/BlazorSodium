using BlazorSodium.Sodium;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BlazorSodium.Services
{
   public interface IBlazorSodiumService
   {
      PasswordHash PasswordHash { get; }
   }

   public class BlazorSodiumService : IBlazorSodiumService
   {
      public PasswordHash PasswordHash { get; }

      public BlazorSodiumService(IJSRuntime jsRuntime)
      {
         IJSInProcessRuntime inProcessRuntime = (IJSInProcessRuntime)jsRuntime;

         PasswordHash = new PasswordHash(inProcessRuntime);
      }
   }
}
