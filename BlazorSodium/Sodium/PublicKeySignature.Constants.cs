namespace BlazorSodium.Sodium
{
   public static partial class PublicKeySignature
   {
      public static uint SIGN_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_sign_BYTES");
      }

      /* see: https://github.com/jedisct1/libsodium.js/issues/305
      public static uint MESSAGEBYTES_MAX
      {
         get => (uint)Sodium.GetConstantNumber("crypto_sign_MESSAGEBYTES_MAX")
      }
      */

      public static uint PUBLIC_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_sign_PUBLICKEYBYTES");
      }

      public static uint PRIVATE_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_sign_SECRETKEYBYTES");
      }

      public static uint SEED_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_sign_SEEDBYTES");
      }
   }
}
