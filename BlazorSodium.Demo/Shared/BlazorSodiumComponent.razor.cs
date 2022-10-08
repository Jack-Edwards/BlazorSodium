using BlazorSodium.Services;
using BlazorSodium.Sodium;
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

      private string SaltString { get; set; }
      protected byte[] Salt { get; set; }
      protected string Password { get; set; }
      protected string HashedPassword { get; set; }

      protected override async Task OnInitializedAsync()
      {
         await BlazorSodiumService.InitializeAsync();
      }

      protected void GenerateRandomSalt()
      {
         Salt = new byte[16];
         PasswordHash.ArgonGenerateSalt().CopyTo(Salt, 0);
         SaltString = Convert.ToHexString(Salt);
      }

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
   }
}
