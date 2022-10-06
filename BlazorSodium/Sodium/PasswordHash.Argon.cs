using Microsoft.JSInterop;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorSodium.Sodium.PasswordHash
{
   public static partial class PasswordHash
   {
      public const uint ARGON_SALTBYTES = 16;

      public const uint crypto_pwhash_argon2i_ALG_ARGON2I13 = 1;
      public const uint crypto_pwhash_argon2id_ALG_ARGON2ID13 = 2;

      public const uint OPSLIMIT_INTERACTIVE = 4;
      public const uint OPSLIMIT_MEDIUM = 4;
      public const uint OPSLIMIT_MODERATE = 6;
      public const uint OPSLIMIT_SENSITIVE = 8;

      public const uint MEMLIMIT_INTERACTIVE = 33554432;
      public const uint MEMLIMIT_MEDIUM = 67108864;
      public const uint MEMLIMIT_MODERATE = 134217728;
      public const uint MEMLIMIT_SENSITIVE = 536870912;

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inProcessRuntime"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_buf.json"/>
      public static byte[] ArgonGenerateSalt(IJSInProcessRuntime inProcessRuntime)
      {
         return inProcessRuntime.Invoke<byte>("window._sodium.randombytes_buf", new object[] { ARGON_SALTBYTES });
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inProcessRuntime"></param>
      /// <param name="password"></param>
      /// <param name="opsLimit"></param>
      /// <param name="memoryLimit"></param>
      /// <param name="algorithm"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_pwhash.json"/>
      public static byte[] HashString(IJSInProcessRuntime inProcessRuntime, string password, uint opsLimit = OPSLIMIT_INTERACTIVE, uint memoryLimit = MEMLIMIT_INTERACTIVE, uint algorithm = 1)
      {
         return inProcessRuntime.Invoke<byte[]>("window._sodium.crypto_pwhash", new object[] { 32, password, randomSalt, opsLimit, memoryLimit, algorithm });
      }
   }
}
