using BlazorSodium.Services;
using BlazorSodium.Sodium;
using BlazorSodium.Sodium.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Buffers;
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
         ShortHashMemoryViewTest();
      }

      protected void RandomBytesMemoryViewTest()
      {
         int size = 500_000;
         int iterations = 50;

         DateTime start2 = DateTime.Now;
         for (int i = 0; i < iterations; i++)
         {
            byte[] bytes = Sodium.RandomBytes.RandomBytes_Buf((uint)size);
         }
         DateTime end2 = DateTime.Now;
         Console.WriteLine($"Baseline - {end2.Ticks - start2.Ticks}");

         DateTime start1 = DateTime.Now;
         byte[] buffer = new byte[size];
         ArraySegment<byte> arraySegment = new ArraySegment<byte>(buffer);
         for (int i = 0; i < iterations; i++)
         {
            Sodium.RandomBytes.RandomBytes_Buf_MemoryView_Test(size, arraySegment);
         }

         DateTime end1 = DateTime.Now;
         Console.WriteLine($"MemoryView_Test - {end1.Ticks - start1.Ticks}");
      }

      protected void ShortHashMemoryViewTest()
      {
         int iterations = 100_000;

         // Another short hash test
         byte[] key = Sodium.ShortHash.Crypto_ShortHash_KeyGen();
         byte[] message = Enumerable.Repeat((byte)0xb4, 500_000).ToArray();

         DateTime start1 = DateTime.Now;
         byte[] hashBuffer = new byte[Sodium.ShortHash.BYTES];
         ArraySegment<byte> hashArraySegment = new ArraySegment<byte>(hashBuffer);

         Span<byte> messageSpan = new Span<byte>(message);
         Span<byte> keySpan = new Span<byte>(key);
         for (int i = 0; i < iterations; i++)
         {
            Sodium.ShortHash.Crypto_ShortHash_MemoryView_Test(hashArraySegment, messageSpan, keySpan);
         }
         DateTime end1 = DateTime.Now;
         Console.WriteLine($"Crypto_ShortHash_MemoryView_Test - {end1.Ticks - start1.Ticks}");

         // Another short hash test
         DateTime start2 = DateTime.Now;
         for (int i = 0; i < iterations; i++)
         {
            byte[] hash = Sodium.ShortHash.Crypto_ShortHash(message, key);
         }
         DateTime end2 = DateTime.Now;
         Console.WriteLine($"Crypto_ShortHash - {end2.Ticks - start2.Ticks}");

         // MemoryView and byte[]
         DateTime start3 = DateTime.Now;
         byte[] hashBuffer2 = new byte[Sodium.ShortHash.BYTES];
         ArraySegment<byte> hashArraySegment2 = new ArraySegment<byte>(hashBuffer2);

         for (int i = 0; i < iterations; i++)
         {
            Sodium.ShortHash.Crypto_ShortHash_MemoryView_Test_2(hashArraySegment2, message, key);
         }
         DateTime end3 = DateTime.Now;
         Console.WriteLine($"Crypto_ShortHash_MemoryView_Test_2 - {end3.Ticks - start3.Ticks}");
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
