namespace BlazorSodium.Sodium
{
   public static partial class AuthenticatedEncryption
   {
      public static uint BEFORE_NM_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_BEFORENMBYTES");
      }

      public static uint MAC_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_MACBYTES");
      }

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
