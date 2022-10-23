namespace BlazorSodium.Sodium
{
   public static partial class SecretStream
   {
      public static uint A_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_secretstream_xchacha20poly1305_ABYTES");
      }

      public static uint HEADER_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_secretstream_xchacha20poly1305_HEADERBYTES");
      }

      public static uint KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_secretstream_xchacha20poly1305_KEYBYTES");
      }

      public static uint KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_secretstream_xchacha20poly1305_KEYBYTES");
      }

      public static uint TAG_FINAL
      {
         get => (uint)Sodium.GetConstantNumber("crypto_secretstream_xchacha20poly1305_TAG_FINAL");
      }

      public static uint TAG_MESSAGE
      {
         get => (uint)Sodium.GetConstantNumber("crypto_secretstream_xchacha20poly1305_TAG_MESSAGE");
      }

      public static uint TAG_PUSH
      {
         get => (uint)Sodium.GetConstantNumber("crypto_secretstream_xchacha20poly1305_TAG_PUSH");
      }

      public static uint TAG_REKEY
      {
         get => (uint)Sodium.GetConstantNumber("crypto_secretstream_xchacha20poly1305_TAG_REKEY");
      }
   }
}
