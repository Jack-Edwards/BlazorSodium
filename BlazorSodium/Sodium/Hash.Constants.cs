namespace BlazorSodium.Sodium
{
   public static partial class Hash
   {
      public static uint BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_hash_BYTES");
      }
   }
}
