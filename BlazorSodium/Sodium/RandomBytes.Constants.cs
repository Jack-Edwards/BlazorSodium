namespace BlazorSodium.Sodium
{
   public static partial class RandomBytes
   {
      /// <summary>
      /// The size of the seed you need to provide to RandomBytes_Buf_Deterministic().
      /// </summary>
      /// <remarks>The sodium module does not expose this value.</remarks>
      public static uint SEED_BYTES
      {
         get => 32U;
      }
   }
}
