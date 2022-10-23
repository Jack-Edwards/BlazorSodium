namespace BlazorSodium.Sodium
{
   public static partial class Sodium
   {
      public static uint SODIUM_LIBRARY_VERSION_MAJOR
      {
         get => (uint)Sodium.GetConstantNumber("SODIUM_LIBRARY_VERSION_MAJOR");
      }

      public static uint SODIUM_LIBRARY_VERSION_MINOR
      {
         get => (uint)Sodium.GetConstantNumber("SODIUM_LIBRARY_VERSION_MINOR");
      }

      public static string SODIUM_VERSION_STRING
      {
         get => Sodium.GetConstantString("SODIUM_VERSION_STRING");
      }
   }
}
