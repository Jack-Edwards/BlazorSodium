namespace BlazorSodium.Sodium
{
   public static partial class SealedPublicKeyBox
   {
      public static uint PUBLIC_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_PUBLICKEYBYTES");
      }

      public static uint PRIVATE_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_SECRETKEYBYTES");
      }

      public static uint SEAL_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_SEALBYTES");
      }
   }
}
