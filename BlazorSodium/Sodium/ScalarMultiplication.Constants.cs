namespace BlazorSodium.Sodium
{
   public static partial class ScalarMultiplication
   {
      public static uint BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_scalarmult_BYTES");
      }

      public static uint SCALAR_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_scalarmult_SCALARBYTES");
      }

      /* Missing from the sodium module
      public static uint CURVE25519_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_scalarmult_curve25519_BYTES");
      }
      */

      /* Missing from the sodium module
      public static uint CURVE25519_SCALARBYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_scalarmult_curve25519_SCALARBYTES");
      }
      */

      /* Missing from the sodium module
      public static uint ED25519_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_scalarmult_ed25519_BYTES");
      }
      */

      /* Missing from the sodium module
      public static uint ED25519_SCALARBYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_scalarmult_ed25519_SCALARBYTES");
      }
      */

      /* Missing from the sodium module
      public static uint RISTRETTO255_BYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_scalarmult_ristretto255_BYTES");
      }
      */

      /* Missing from the sodium module
      public static uint RISTRETTO255_SCALARBYTES
      {
         get => (uint)Sodium.GetConstantNumber("crypto_scalarmult_ristretto255_SCALARBYTES");
      }
      */
   }
}
