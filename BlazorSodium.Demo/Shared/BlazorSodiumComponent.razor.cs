using BlazorSodium.Services;
using BlazorSodium.Sodium;
using BlazorSodium.Sodium.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Runtime.Versioning;
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

         /*
         for (int i = 0; i < 100; i++)
         {
            GenerateRandomNumber();
         }
         */
      }

      private string SaltString { get; set; }
      protected byte[] Salt { get; set; }

      [SupportedOSPlatform("browser")]
      protected void GenerateRandomSalt()
      {
         Salt = new byte[16];
         RandomBytes.RandomBytes_Buf(16).CopyTo(Salt, 0);
         SaltString = Convert.ToHexString(Salt);
      }

      protected string PublicKey { get; set; }
      protected string PrivateKey { get; set; }

      [SupportedOSPlatform("browser")]
      protected void GeneratePublicKeySignatureKeyPair()
      {
         Ed25519KeyPair keyPair = PublicKeySignature.Crypto_Sign_KeyPair();
         PublicKey = Convert.ToHexString(keyPair.PublicKey);
         PrivateKey = Convert.ToHexString(keyPair.PrivateKey);
      }

      [SupportedOSPlatform("browser")]
      protected void GenerateRandomNumber()
      {
         uint randomNumber = RandomBytes.RandomBytes_Random();
         Console.WriteLine(randomNumber);
      }
   }
}
