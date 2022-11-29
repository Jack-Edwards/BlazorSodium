namespace BlazorSodium.Sodium
{
   public static partial class GenericHash
   {
      public static uint BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_generichash_BYTES");
      }

      public static uint BYTES_MAX
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_generichash_BYTES_MAX");
      }

      public static uint BYTES_MIN
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_generichash_BYTES_MIN");
      }

      public static uint KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_generichash_KEYBYTES");
      }

      public static uint KEY_BYTES_MAX
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_generichash_KEYBYTES_MAX");
      }

      public static uint KEY_BYTES_MIN
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_generichash_KEYBYTES_MIN");
      }
   }
}
