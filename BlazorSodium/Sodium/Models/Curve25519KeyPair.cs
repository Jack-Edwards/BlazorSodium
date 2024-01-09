﻿using System;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium.Models
{
   public class Curve25519KeyPair : IKeyPair
   {
      private const string _keyType = "curve25519";

      public byte[] PrivateKey { get; init; }
      public byte[] PublicKey { get; init; }

      public Curve25519KeyPair(byte[] privateKey, byte[] publicKey)
      {
         PrivateKey = privateKey;
         PublicKey = publicKey;
      }

      [SupportedOSPlatform("browser")]
      public static Curve25519KeyPair FromJavaScript(JSObject jsObject)
      {
         string keyType = jsObject.GetPropertyAsString("keyType")
            ?? throw new NullReferenceException("'keyType' cannot be null.");
         
         if (keyType != _keyType)
         {
            throw new ArgumentException($"'{keyType}' is not a valid key type for this class", nameof(jsObject));
         }

         byte[] privateKey = jsObject.GetPropertyAsByteArray("privateKey")
            ?? throw new NullReferenceException("'privateKey' cannot be null.");

         byte[] publicKey = jsObject.GetPropertyAsByteArray("publicKey")
            ?? throw new NullReferenceException("'publicKey' cannot be null.");
            
         return new Curve25519KeyPair(privateKey, publicKey);
      }
   }
}
