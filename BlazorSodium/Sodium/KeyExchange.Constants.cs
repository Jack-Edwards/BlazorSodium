namespace BlazorSodium.Sodium
{
   public partial class KeyExchange
   {
      public static uint PUBLIC_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_kx_PUBLICKEYBYTES");
      }

      public static uint PRIVATE_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_kx_SECRETKEYBYTES");
      }

      public static uint SEED_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_kx_SEEDBYTES");
      }

      public static uint SESSION_KEY_BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_kx_SESSIONKEYBYTES");
      }
   }
}
