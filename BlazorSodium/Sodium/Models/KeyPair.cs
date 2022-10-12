using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSodium.Sodium.Models
{
   public class KeyPair
   {
      public string KeyType { get; set; }
      public byte[] PrivateKey { get; set; }
      public byte[] PublicKey { get; set; }

      public KeyPair(string keyType, byte[] privateKey, byte[] publicKey)
      {
         KeyType = keyType;
         PrivateKey = privateKey;
         PublicKey = publicKey;
      }
   }
}
