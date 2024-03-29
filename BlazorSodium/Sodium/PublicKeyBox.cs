﻿using BlazorSodium.Sodium.Models;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class PublicKeyBox
   {
      /// <summary>
      /// Compute a shared key from the provided public and private keys.
      /// </summary>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_beforenm.json"/>
      public static byte[] Crypto_Box_Before_NM(byte[] publicKey, byte[] privateKey)
         => Crypto_Box_Before_NM_Interop(publicKey, privateKey);

      /// <summary>
      /// Encrypts a message using the provided keys and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns>An object containing the authentication tag and encrypted message.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_detached.json"/>
      public static PublicKeyBoxDetached Crypto_Box_Detached(byte[] message, byte[] nonce, byte[] publicKey, byte[] privateKey)
      {
         JSObject jsObject = Crypto_Box_Detached_Interop(message, nonce, publicKey, privateKey);
         return PublicKeyBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts a message using the provided keys and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns>An object containing the authentication tag and encrypted message.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_detached.json"/>
      public static PublicKeyBoxDetached Crypto_Box_Detached(string message, byte[] nonce, byte[] publicKey, byte[] privateKey)
      {
         JSObject jsObject = Crypto_Box_Detached_Interop(message, nonce, publicKey, privateKey);
         return PublicKeyBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts a message using the provided keys and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns>A sequence of bytes containing the encrypted message and authentication tag.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy.json"/>
      public static byte[] Crypto_Box_Easy(byte[] message, byte[] nonce, byte[] publicKey, byte[] privateKey)
         => Crypto_Box_Easy_Interop(message, nonce, publicKey, privateKey);

      /// <summary>
      /// Encrypts a message using the provided keys and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns>A sequence of bytes containing the encrypted message and authentication tag.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy.json"/>
      public static byte[] Crypto_Box_Easy(string message, byte[] nonce, byte[] publicKey, byte[] privateKey)
         => Crypto_Box_Easy_Interop(message, nonce, publicKey, privateKey);

      /// <summary>
      /// Encrypts a message using a pre-calculated shared key and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="secretKey"></param>
      /// <returns>A sequence of bytes containing the encrypted message and authentication tag.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy_afternm.json"/>
      public static byte[] Crypto_Box_Easy_After_NM(byte[] message, byte[] nonce, byte[] secretKey)
         => Crypto_Box_Easy_After_NM_Interop(message, nonce, secretKey);

      /// <summary>
      /// Encrypts a message using a pre-calculated shared key and nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="secretKey"></param>
      /// <returns>A sequence of bytes containing the encrypted message and authentication tag.</returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy_afternm.json"/>
      public static byte[] Crypto_Box_Easy_After_NM(string message, byte[] nonce, byte[] secretKey)
         => Crypto_Box_Easy_After_NM_Interop(message, nonce, secretKey);

      /// <summary>
      /// Randomly generate an X25519 key pair.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_keypair.json"/>
      public static X25519KeyPair Crypto_Box_KeyPair()
      {
         JSObject jsObject = Crypto_Box_KeyPair_Interop();
         return X25519KeyPair.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Decrypt and verify the provided detached box.
      /// </summary>
      /// <param name="detachedBox"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_open_detached.json"/>
      public static byte[] Crypto_Box_Open_Detached(PublicKeyBoxDetached detachedBox, byte[] nonce, byte[] publicKey, byte[] privateKey)
         => Crypto_Box_Open_Detached_Interop(detachedBox.Cipher, detachedBox.MessageAuthenticationCode, nonce, publicKey, privateKey);

      /// <summary>
      /// Decrypt and verify a ciphertext produced by Crypto_Box_Easy().
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="publicKey"></param>
      /// <param name="privateKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy.json"/>
      public static byte[] Crypto_Box_Open_Easy(byte[] message, byte[] nonce, byte[] publicKey, byte[] privateKey)
         => Crypto_Box_Open_Easy_Interop(message, nonce, publicKey, privateKey);

      /// <summary>
      /// Decrypt and verify a ciphertext using a pre-calculated shared key.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="nonce"></param>
      /// <param name="sharedKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_easy_afternm.json"/>
      public static byte[] Crypto_Box_Open_Easy_After_NM(byte[] message, byte[] nonce, byte[] sharedKey)
         => Crypto_Box_Easy_After_NM_Interop(message, nonce, sharedKey);

      /// <summary>
      /// Derive an X25519 key pair from a seed.
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_box_seed_keypair.json"/>
      public static X25519KeyPair Crypto_Box_Seed_KeyPair(byte[] seed)
      {
         JSObject jsObject = Crypto_Box_Seed_KeyPair_Interop(seed);
         return X25519KeyPair.FromJavaScript(jsObject);
      }
   }
}
