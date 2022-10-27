namespace BlazorSodium.Sodium
{
   public static partial class KeyDerivation
   {
      public static uint BYTES_MAX
      {
         get => (uint)Sodium.GetConstantNumber("crypto_kdf_BYTES_MAX");
      }

      public static uint BYTES_MIN
      {
         get => (uint)Sodium.GetConstantNumber("crypto_kdf_BYTES_MIN");
      }

      public static uint CONTEXTBYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_kdf_CONTEXTBYTES");
      }

      public static uint KEYBYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_kdf_KEYBYTES");
      }
   }
}
