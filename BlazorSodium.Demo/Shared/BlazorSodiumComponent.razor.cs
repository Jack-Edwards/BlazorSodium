using BlazorSodium.Services;
using BlazorSodium.Sodium;
using BlazorSodium.Sodium.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSodium.Demo.Shared
{
   public partial class BlazorSodiumComponent : ComponentBase
   {
      [Inject]
      IBlazorSodiumService BlazorSodiumService { get; set; }

      protected override async Task OnInitializedAsync()
      {
         await BlazorSodiumService.InitializeAsync();
      }

      private string SaltString { get; set; }
      protected byte[] Salt { get; set; }
      protected void GenerateRandomSalt()
      {
         Salt = new byte[16];
         RandomBytes.RandomBytes_Buf(16).CopyTo(Salt, 0);
         SaltString = Convert.ToHexString(Salt);
      }

      protected string Password { get; set; }
      protected string HashedPassword { get; set; }
      protected void GeneratePasswordHash()
      {
         if (Password is not null && Salt is not null)
         {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(Password);
            byte[] passwordHash = PasswordHash.ArgonHashBinary(
               outputLength: 32,
               password: passwordBytes,
               salt: Salt,
               opsLimit: PasswordHash.OPSLIMIT_INTERACTIVE,
               memoryLimit: PasswordHash.MEMLIMIT_INTERACTIVE,
               algorithm: PasswordHash.crypto_pwhash_argon2i_ALG_ARGON2I13);

            HashedPassword = Convert.ToHexString(passwordHash);
         }
      }

      protected string PublicKey { get; set; }
      protected string PrivateKey { get; set; }
      protected void GeneratePublicKeySignatureKeyPair()
      {
         KeyPair keyPair = PublicKeySignature.Crypto_Sign_KeyPair();
         PublicKey = Convert.ToHexString(keyPair.PublicKey);
         PrivateKey = Convert.ToHexString(keyPair.PrivateKey);
      }
   }
}
