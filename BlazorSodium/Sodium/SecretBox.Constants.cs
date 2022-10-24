namespace BlazorSodium.Sodium
{
   public static partial class SecretBox
   {
      public static uint KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_secretbox_KEYBYTES");
      }

      public static uint MAC_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_secretbox_MACBYTES");
      }

      public static uint NONCE_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_secretbox_NONCEBYTES");
      }
   }
}
