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

      public static async Task<byte[]> HashStringAsync(IJSInProcessRuntime inProcessRuntime, IJSRuntime standardRuntime, string password, int opsLimit = OPSLIMIT_INTERACTIVE, int memoryLimit = MEMLIMIT_INTERACTIVE)
      {
         uint saltLength = 16;
         Console.WriteLine("getting random bytes");

         // I don't know what type 'buf' is ahead of time.
         // ref: https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_buf.json
         object randomBytesAsObject = inProcessRuntime.Invoke<object>("window._sodium.randombytes_buf", new object[] { saltLength });
         Console.WriteLine($"Object type is: {randomBytesAsObject.GetType()}"); // System.Text.Json.JsonElement

         // Trying as JsonElement
         JsonElement randomBytesAsJsonElement = inProcessRuntime.Invoke<JsonElement>("window._sodium.randombytes_buf", new object[] { saltLength });
         Console.WriteLine($"Object raw text is: {randomBytesAsJsonElement.GetRawText()}"); // {"__byte[]":0}

         // Trying as byte[]
         // It works!
         byte[] randomBytesAsBytes = inProcessRuntime.Invoke<byte[]>("window._sodium.randombytes_buf", new object[] { saltLength });
         Console.WriteLine($"Object length is: {randomBytesAsBytes?.Length}");
         foreach (var item in randomBytesAsBytes)
         {
            Console.WriteLine(item.ToString());
         }

         // The commented code below produces the following exception: System.Text.Json.JsonException: JSON serialization is attempting to deserialize an unexpected byte array.
         //byte[] randomBytesAsAsyncBytes = await standardRuntime.InvokeAsync<byte[]>("window._sodium.randombytes_buf", new object[] { saltLength });

         Console.WriteLine("hashing password");
         int argonAlt = 1; // or 2
         byte[] randomSalt = new byte[] { 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, };

         // ref: https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_pwhash.json
         byte[] passwordHash = inProcessRuntime.Invoke<byte[]>("window._sodium.crypto_pwhash", new object[] { 32, password, randomSalt, opsLimit, memoryLimit, 1 });
         Console.WriteLine(Convert.ToBase64String(passwordHash)); // yO4j8RrepwXrnfUsZvtWAKYWouYjx/AEERpUJ48xnhk=

         return passwordHash;
      }
   }
}
