namespace BlazorSodium.Sodium
{
   public static partial class PublicKeySignature
   {
      public static uint SIGN_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_sign_BYTES");
      }

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

      public static uint ED25519_SIGN_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_sign_ed25519_BYTES");
      }

      public static uint ED25519_PUBLIC_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_sign_ed25519_PUBLICKEYBYTES");
      }

      public static uint ED25519_PRIVATE_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_sign_ed25519_SECRETKEYBYTES");
      }

      public static uint ED25519_SEED_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_sign_ed25519_SEEDBYTES");
      }
   }
}
