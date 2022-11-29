namespace BlazorSodium.Sodium
{
   public static partial class Authentication
   {
      public static uint BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_auth_BYTES");
      }

      public static uint KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_auth_KEYBYTES");
      }
   }
}
