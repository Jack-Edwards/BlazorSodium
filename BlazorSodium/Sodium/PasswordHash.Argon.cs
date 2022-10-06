using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorSodium.Sodium
{
   public partial class PasswordHash
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
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/randombytes_buf.json"/>
      public byte[] ArgonGenerateSalt()
      {
         return _runtime.Invoke<byte[]>("window._sodium.randombytes_buf", new object[] { ARGON_SALTBYTES });
      }

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
      public byte[] ArgonHashBinary(uint outputLength, byte[] password, byte[] salt, uint opsLimit, uint memoryLimit, uint algorithm)
      {
         return _runtime.Invoke<byte[]>("window._sodium.crypto_pwhash", new object[] { outputLength, password, salt, opsLimit, memoryLimit, algorithm });
      }
   }
}
