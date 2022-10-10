using System;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorSodium.Sodium
{
   public static partial class PasswordHash
   {
      public const int ARGON_SALTBYTES = 16;

      public const int crypto_pwhash_argon2i_ALG_ARGON2I13 = 1;
      public const int crypto_pwhash_argon2id_ALG_ARGON2ID13 = 2;

      public const int OPSLIMIT_INTERACTIVE = 4;
      public const int OPSLIMIT_MEDIUM = 4;
      public const int OPSLIMIT_MODERATE = 6;
      public const int OPSLIMIT_SENSITIVE = 8;

      public const int MEMLIMIT_INTERACTIVE = 33554432;
      public const int MEMLIMIT_MEDIUM = 67108864;
      public const int MEMLIMIT_MODERATE = 134217728;
      public const int MEMLIMIT_SENSITIVE = 536870912;

      /// <summary>
      /// 
      /// </summary>
      /// <param name="outputLength"></param>
      /// <param name="password"></param>
      /// <param name="salt"></param>
      /// <param name="opsLimit"></param>
      /// <param name="memoryLimit"></param>
      /// <param name="algorithm"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_pwhash.json"/>
      [JSImport("sodium.crypto_pwhash", "blazorSodium")]
      public static partial byte[] ArgonHashBinary(int outputLength, byte[] password, byte[] salt, int opsLimit, int memoryLimit, int algorithm);
   }
}
