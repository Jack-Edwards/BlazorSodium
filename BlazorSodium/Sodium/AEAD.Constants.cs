namespace BlazorSodium.Sodium
{
   public static partial class AEAD
   {
      public static uint CHACHA20POLY1305_A_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_aead_chacha20poly1305_ABYTES");
      }

      public static uint CHACHA20POLY1305_IETF_A_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_aead_chacha20poly1305_IETF_ABYTES");
      }

      public static uint CHACHA20POLY1305_IETF_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_aead_chacha20poly1305_IETF_KEYBYTES");
      }

      /* see: https://github.com/jedisct1/libsodium.js/issues/305
      public static uint CHACHA20POLY1305_IETC_MESSAGE_BYTES_MAX
      {
         get => (uint)Sodium.GetConstantNumber("crypto_aead_chacha20poly1305_IETF_MESSAGEBYTES_MAX");
      }
      */

      public static uint CHACHA20POLY1305_IETF_NPUB_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_aead_chacha20poly1305_IETF_NPUBBYTES");
      }

      public static uint CHACHA20POLY1305_IETF_NSEC_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_aead_chacha20poly1305_IETF_NSECBYTES");
      }

      public static uint CHACHA20POLY1305_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_aead_chacha20poly1305_KEYBYTES");
      }

      /* see: https://github.com/jedisct1/libsodium.js/issues/305
      public static uint CHACHA20POLY1305_MESSAGE_BYTES_MAX
      {
         get => (uint)Sodium.GetConstantNumber("​crypto_aead_chacha20poly1305_MESSAGEBYTES_MAX");
      }
      */

      public static uint CHACHA20POLY1305_NPUB_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_aead_chacha20poly1305_NPUBBYTES");
      }

      public static uint CHACHA20POLY1305_NSEC_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_aead_chacha20poly1305_NSECBYTES");
      }

      public static uint XCHACHA20POLY1305_IETF_A_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_aead_xchacha20poly1305_IETF_ABYTES");
      }

      public static uint XCHACHA20POLY1305_IETF_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_aead_xchacha20poly1305_IETF_KEYBYTES");
      }

      /* see: https://github.com/jedisct1/libsodium.js/issues/305
      public static uint XCHACHA20POLY1305_IETC_MESSAGE_BYTES_MAX
      {
         get => (uint)Sodium.GetConstantNumber("crypto_aead_xchacha20poly1305_IETF_MESSAGEBYTES_MAX");
      }
      */

      public static uint XCHACHA20POLY1305_IETF_NPUB_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_aead_xchacha20poly1305_IETF_NPUBBYTES");
      }

      public static uint XCHACHA20POLY1305_IETF_NSEC_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_aead_xchacha20poly1305_IETF_NSECBYTES");
      }
   }
}
