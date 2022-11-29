namespace BlazorSodium.Sodium
{
   public static partial class Hash
   {
      public static uint BYTES
      {
         get => (uint)Sodium.GetConstantNumber_Interop("crypto_hash_BYTES");
      }
   }
}
