namespace BlazorSodium.Sodium
{
   public static partial class StreamCipher
   {
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

      public static uint XCHACHA20_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_xchacha20_KEYBYTES");
      }

      public static uint XCHACHA20_NONCE_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_stream_xchacha20_NONCEBYTES");
      }
   }
}
