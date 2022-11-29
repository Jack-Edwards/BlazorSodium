namespace BlazorSodium.Sodium
{
   public static partial class KeyDerivation
   {
      public static uint BYTES_MAX
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_kdf_BYTES_MAX");
      }

      public static uint BYTES_MIN
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_kdf_BYTES_MIN");
      }

      public static uint CONTEXT_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_kdf_CONTEXTBYTES");
      }

      public static uint KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_kdf_KEYBYTES");
      }
   }
}
