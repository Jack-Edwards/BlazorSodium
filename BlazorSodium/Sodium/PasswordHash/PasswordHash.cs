using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Text.Json;

namespace BlazorSodium.Sodium.PasswordHash
{
   public static class PasswordHash
   {
      private const int OPSLIMIT_INTERACTIVE = 4;
      private const int OPSLIMIT_MEDIUM = 4;
      private const int OPSLIMIT_MODERATE = 6;
      private const int OPSLIMIT_SENSITIVE = 8;

      private const int MEMLIMIT_INTERACTIVE = 33554432;
      private const int MEMLIMIT_MEDIUM = 67108864;
      private const int MEMLIMIT_MODERATE = 134217728;
      private const int MEMLIMIT_SENSITIVE = 536870912;

      public static async ValueTask<byte[]> HashStringAsync(IJSRuntime jsRuntime, string password, int opsLimit = OPSLIMIT_INTERACTIVE, int memoryLimit = MEMLIMIT_INTERACTIVE)
      {
         uint saltLength = 16;
         Console.WriteLine("getting random bytes");
         JsonElement randomBytes = await jsRuntime.InvokeAsync<JsonElement>("window._sodium.randombytes_buf", new object[] { saltLength });
         Console.WriteLine($"random bytes value is {randomBytesBuf.GetRawText()}"); // {"__byte[]":0}

         Console.WriteLine("hashing password");
         int argonAlt = 1; // or 2
         return await jsRuntime.InvokeAsync<byte[]>("window._sodium.crypto_pwhash", new object[] { 32, password, randomBytes, opsLimit, memoryLimit, 1 });
      }
   }
}
