namespace BlazorSodium.Sodium
{
   public static partial class PublicKeyBox
   {
      public static uint BEFORE_NM_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_BEFORENMBYTES");
      }

      public static uint MAC_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_MACBYTES");
      }

      /* see: https://github.com/jedisct1/libsodium.js/issues/305
      public static uint MESSAGEBYTES_MAX
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_MESSAGEBYTES_MAX");
      }
      */

      public static uint NONCE_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_NONCEBYTES");
      }

      public static uint PUBLIC_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_PUBLICKEYBYTES");
      }

      public static uint PRIVATE_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_SECRETKEYBYTES");
      }

      public static uint SEED_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_SEEDBYTES");
      }
   }
}
