namespace BlazorSodium.Sodium
{
   public static partial class StreamCipher
   {
      public static uint KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_KEYBYTES");
      }

      public static uint NONCE_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_NONCEBYTES");
      }

      public static uint CHACHA20_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_chacha20_KEYBYTES");
      }

      public static uint CHACHA20_NONCE_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_chacha20_NONCEBYTES");
      }

      public static uint CHACHA20_IETF_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_chacha20_ietf_KEYBYTES");
      }

      public static uint CHACHA20_IETF_NONCE_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_chacha20_ietf_NONCEBYTES");
      }

      public static uint SALSA2012_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_salsa2012_KEYBYTES");
      }

      public static uint SALSA2012_NONCE_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_salsa2012_NONCEBYTES");
      }

      public static uint SALSA208_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_salsa208_KEYBYTES");
      }

      public static uint SALSA208_NONCE_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_salsa208_NONCEBYTES");
      }

      public static uint SALSA20_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_salsa20_KEYBYTES");
      }

      public static uint SALSA20_NONCE_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_salsa20_NONCEBYTES");
      }

      public static uint XCHACHA20_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_xchacha20_KEYBYTES");
      }

      public static uint XCHACHA20_NONCE_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_xchacha20_NONCEBYTES");
      }

      public static uint XSALSA20_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_xsalsa20_KEYBYTES");
      }

      public static uint XSALSA20_NONCE_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_xsalsa20_NONCEBYTES");
      }
   }
}
