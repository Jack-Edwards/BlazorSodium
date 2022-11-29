namespace BlazorSodium.Sodium
{
   public static partial class SecretBox
   {
      public static uint KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_secretbox_KEYBYTES");
      }

      public static uint MAC_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_secretbox_MACBYTES");
      }

      /* see: https://github.com/jedisct1/libsodium.js/issues/305
      public static uint MESSAGEBYTES_MAX
      {
         get => (uint)Sodium.GetConstantNumber("crypto_secretbox_MESSAGEBYTES_MAX");
      }
      */

      public static uint NONCE_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_secretbox_NONCEBYTES");
      }
   }
}
