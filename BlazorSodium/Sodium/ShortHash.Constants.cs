namespace BlazorSodium.Sodium
{
   public static partial class ShortHash
   {
      public static uint SHORTHASH_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_shorthash_BYTES");
      }

      public static uint SHORTHASH_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_shorthash_KEYBYTES");
      }

      public static uint SIPHASH24_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_shorthash_siphash24_BYTES");
      }

      public static uint SIPHASH24_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_shorthash_siphash24_KEYBYTES");
      }

      public static uint SIPHASH24X_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_shorthash_siphashx24_BYTES");
      }

      public static uint SIPHASH24X_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_shorthash_siphashx24_KEYBYTES");
      }
   }
}
