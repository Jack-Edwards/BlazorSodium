namespace BlazorSodium.Sodium.Models
{
   internal interface IKeyPair
   {
      byte[] PrivateKey { get; }
      byte[] PublicKey { get; }
   }
}
