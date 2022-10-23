namespace BlazorSodium.Sodium
{
   public static partial class SealedBox
   {
      public static uint SEAL_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_SEALBYTES");
      }

      public static uint SEED_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_box_SEEDBYTES");
      }
   }
}
