﻿using System;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium.Models
{
   public class SecretBoxDetached
   {
      public byte[] MessageAuthenticationCode { get; init; }
      public byte[] Cipher { get; init; }

      public SecretBoxDetached(byte[] messageAuthenticationCode, byte[] cipher)
      {
         MessageAuthenticationCode = messageAuthenticationCode;
         Cipher = cipher;
      }

      [SupportedOSPlatform("browser")]
      public static SecretBoxDetached FromJavaScript(JSObject jsObject)
      {
         byte[] mac = jsObject.GetPropertyAsByteArray("mac")
            ?? throw new NullReferenceException("'mac' cannot be null.");
         
         byte[] cipher = jsObject.GetPropertyAsByteArray("cipher")
            ?? throw new NullReferenceException("'cipher' cannot be null.");
         
         return new SecretBoxDetached(mac, cipher);
      }
   }
}
