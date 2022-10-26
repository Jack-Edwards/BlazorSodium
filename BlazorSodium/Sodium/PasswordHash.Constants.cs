namespace BlazorSodium.Sodium
{
   public partial class PasswordHash
   {
      public static uint ALG_ARGON2I13
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_ALG_ARGON2I13");
      }

      public static uint ALG_ARGON2ID13
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_ALG_ARGON2ID13");
      }

      public static uint ALG_DEFAULT
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_ALG_DEFAULT");
      }

      /* see: https://github.com/jedisct1/libsodium.js/issues/305
      public static uint BYTES_MAX
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_BYTES_MAX");
      }
      */

      public static uint BYTES_MIN
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_BYTES_MIN");
      }

      public static uint MEMLIMIT_INTERACTIVE
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_MEMLIMIT_INTERACTIVE");
      }

      /* see: https://github.com/jedisct1/libsodium.js/issues/305
      public static uint MEMLIMIT_MAX
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_MEMLIMIT_MAX");
      }
      */

      public static uint MEMLIMIT_MIN
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_MEMLIMIT_MIN");
      }

      public static uint MEMLIMIT_MODERATE
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_MEMLIMIT_MODERATE");
      }

      public static uint MEMLIMIT_SENSITIVE
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_MEMLIMIT_SENSITIVE");
      }

      public static uint OPSLIMIT_INTERACTIVE
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_OPSLIMIT_INTERACTIVE");
      }

      /* see: https://github.com/jedisct1/libsodium.js/issues/305
      public static uint OPSLIMIT_MAX
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_OPSLIMIT_MAX");
      }
      */

      public static uint OPSLIMIT_MIN
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_OPSLIMIT_MIN");
      }

      public static uint OPSLIMIT_MODERATE
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_OPSLIMIT_MODERATE");
      }

      public static uint OPSLIMIT_SENSITIVE
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_OPSLIMIT_SENSITIVE");
      }

      /* see: https://github.com/jedisct1/libsodium.js/issues/305
      public static uint PASSWD_MAX
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_PASSWD_MAX");
      }
      */

      public static uint PASSWD_MIN
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_PASSWD_MIN");
      }

      public static uint SALTBYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_SALTBYTES");
      }

      public static uint STRBYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_pwhash_STRBYTES");
      }

      public static string STRPREFIX
      {
         get => Sodium.GetConstantString("crypto_pwhash_STRPREFIX");
      }
   }
}
