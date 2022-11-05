using BlazorSodium.Services;
using BlazorSodium.Sodium;
using BlazorSodium.Sodium.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
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
         Sodium.Sodium.PrintSodium();

         /*
         if (OperatingSystem.IsBrowser())
         {
            string password = "my test password";
            uint interactiveOpsLimit = PasswordHash.OPSLIMIT_INTERACTIVE;
            uint interactiveMemLimit = PasswordHash.MEMLIMIT_INTERACTIVE;
            string hashedPassword = PasswordHash.Crypto_PwHash_Str(password, interactiveOpsLimit, interactiveMemLimit);
            Console.WriteLine($"Hashed password: {hashedPassword}");

            bool needsRehash = PasswordHash.Crypto_PwHash_Str_Needs_Rehash(hashedPassword, interactiveOpsLimit, interactiveMemLimit);
            Console.WriteLine($"Password needs rehash: {needsRehash}");

            bool invalidVerification = PasswordHash.Crypto_PwHash_Str_Verify(hashedPassword, "bad password");
            Console.WriteLine($"Bad password is caught: {!invalidVerification}");

            bool validVerification = PasswordHash.Crypto_PwHash_Str_Verify(hashedPassword, password);
            Console.WriteLine($"Good password is accepted: {validVerification}");
         }

         if (OperatingSystem.IsBrowser())
         {
            GenericHash.Crypto_GenericHash_Init(GenericHash.BYTES);
         }
         */

         // short hash test
         Sodium.ShortHash.Crypto_ShortHash_Malloc_Test();

         byte[] key = Sodium.ShortHash.Crypto_ShortHash_KeyGen();
         byte[] message = Encoding.UTF8.GetBytes("test");

         byte[] hashBuffer = new byte[Sodium.ShortHash.BYTES];
         Sodium.ShortHash.Crypto_ShortHash_Test_Pointers(hashBuffer, message, key);
         Console.WriteLine(Convert.ToHexString(hashBuffer));

         DateTime startTwo = DateTime.Now;
         for (int i = 0; i < 100_000; i++)
         {
            byte[] hash = new byte[Sodium.ShortHash.BYTES];
            Sodium.ShortHash.Crypto_ShortHash_Test(hash, message, key);
         }
         DateTime endTwo = DateTime.Now;

         Console.WriteLine($"{endTwo.Ticks - startTwo.Ticks}");

         DateTime start = DateTime.Now;
         for(int i = 0; i < 100_000; i++)
         {
            byte[] hash = Sodium.ShortHash.Crypto_ShortHash(message, key);
         }
         DateTime end = DateTime.Now;
         Console.WriteLine($"{end.Ticks - start.Ticks}");
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

      protected string SecretStreamKey { get; set; }
      protected byte[] SecretStreamKeyBytes { get; set; }
      [SupportedOSPlatform("browser")]
      protected void GenerateSecretStreamKey()
      {
         uint keySize = SecretStream.KEY_BYTES;
         SecretStreamKeyBytes = new byte[keySize];
         SecretStream.Crypto_SecretStream_XChaCha20Poly1305_KeyGen().CopyTo(SecretStreamKeyBytes, 0);
         SecretStreamKey = Convert.ToHexString(SecretStreamKeyBytes);
      }

      protected string SecretStreamPlaintext { get; set; }
      protected string HexCiphertext { get; set; }
      protected string DecryptedText { get; set; }
      [SupportedOSPlatform("browser")]
      protected void EncryptSecretStream()
      {
         // Encrypt
         SecretStreamPushData initData = SecretStream.Crypto_SecretStream_XChaCha20Poly1305_Init_Push(SecretStreamKeyBytes);
         string[] stringParts = SecretStreamPlaintext.Split(' ');
         List<byte[]> cipherParts = new List<byte[]>(stringParts.Length);

         for (int i = 0; i < stringParts.Length; i++)
         {
            uint tag = i + 1 < stringParts.Length
               ? SecretStream.TAG_MESSAGE
               : SecretStream.TAG_FINAL;

            byte[] cipherPart = SecretStream.Crypto_SecretStream_XChaCha20Poly1305_Push(initData.StateAddress, stringParts[i], tag);
            cipherParts.Add(cipherPart);
         }
         HexCiphertext = Convert.ToHexString(cipherParts.SelectMany(x => x).ToArray());
         Console.WriteLine(HexCiphertext);

         // Decrypt
         StateAddress stateAddress = SecretStream.Crypto_SecretStream_XChaCha20Poly1305_Init_Pull(initData.Header, SecretStreamKeyBytes);
         List<byte[]> plaintextParts = new List<byte[]>(cipherParts.Count);
         for (int i = 0; i < cipherParts.Count; i++)
         {
            SecretStreamPullData pullData = SecretStream.Crypto_SecretStream_XChaCha20Poly1305_Pull(stateAddress, cipherParts[i], null);
            plaintextParts.Add(pullData.Message);
         }
         DecryptedText = Encoding.UTF8.GetString(plaintextParts.SelectMany(x => x).ToArray());
      }
   }
}
