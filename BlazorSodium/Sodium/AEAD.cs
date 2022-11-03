using BlazorSodium.Sodium.Models;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   public static partial class AEAD
   {
      /// <summary>
      /// Verifies and decrypts a ciphertext produced by Crypto_AEAD_ChaCha20Poly1305_Encrypt().
      /// </summary>
      /// <param name="ciphertext"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_decrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_Decrypt(byte[] ciphertext, byte[] publicNonce, byte[] key, byte[] additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_Decrypt_Internal(secretNonce: null, ciphertext: ciphertext, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Verifies and decrypts a ciphertext produced by Crypto_AEAD_ChaCha20Poly1305_Encrypt().
      /// </summary>
      /// <param name="ciphertext"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_decrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_Decrypt(byte[] ciphertext, byte[] publicNonce, byte[] key, string additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_Decrypt_Internal(secretNonce: null, ciphertext: ciphertext, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Verifies and decrypts a detached box produced by Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached().
      /// </summary>
      /// <param name="detachedBox"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_decrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_Decrypt_Detached(AEADBoxDetached detachedBox, byte[] publicNonce, byte[] key, byte[] additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_Decrypt_Detached_Internal(secretNonce: null, ciphertext: detachedBox.Cipher, mac: detachedBox.MessageAuthenticationCode, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Verifies and decrypts a detached box produced by Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached().
      /// </summary>
      /// <param name="detachedBox"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_decrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_Decrypt_Detached(AEADBoxDetached detachedBox, byte[] publicNonce, byte[] key, string additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_Decrypt_Detached_Internal(secretNonce: null, ciphertext: detachedBox.Cipher, mac: detachedBox.MessageAuthenticationCode, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_Encrypt(byte[] message, byte[] publicNonce, byte[] key, byte[] additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_Encrypt_Internal(message: message, secretNonce: null, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_Encrypt(byte[] message, byte[] publicNonce, byte[] key, string additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_Encrypt_Internal(message: message, secretNonce: null, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_Encrypt(string message, byte[] publicNonce, byte[] key, byte[] additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_Encrypt_Internal(message: message, secretNonce: null, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_Encrypt(string message, byte[] publicNonce, byte[] key, string additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_Encrypt_Internal(message: message, secretNonce: null, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static AEADBoxDetached Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached(byte[] message, byte[] publicNonce, byte[] key, byte[] additionalData = null)
      {
         JSObject jsObject = Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);
         return AEADBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static AEADBoxDetached Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached(byte[] message, byte[] publicNonce, byte[] key, string additionalData = null)
      {
         JSObject jsObject = Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);
         return AEADBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static AEADBoxDetached Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached(string message, byte[] publicNonce, byte[] key, byte[] additionalData = null)
      {
         JSObject jsObject = Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);
         return AEADBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static AEADBoxDetached Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached(string message, byte[] publicNonce, byte[] key, string additionalData = null)
      {
         JSObject jsObject = Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);
         return AEADBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Verifies and decrypts a ciphertext produced by Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt().
      /// </summary>
      /// <param name="ciphertext"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_decrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Decypt(byte[] ciphertext, byte[] publicNonce, byte[] key, byte[] additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_IETF_Decrypt_Internal(secretNonce: null, ciphertext: ciphertext, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Verifies and decrypts a ciphertext produced by Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt().
      /// </summary>
      /// <param name="ciphertext"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_decrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Decypt(byte[] ciphertext, byte[] publicNonce, byte[] key, string additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_IETF_Decrypt_Internal(secretNonce: null, ciphertext: ciphertext, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Verifies and decrypts a detached box produced by Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt_Detached().
      /// </summary>
      /// <param name="detachedBox"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_decrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Decrypt_Detached(AEADBoxDetached detachedBox, byte[] publicNonce, byte[] key, byte[] additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_IETF_Decrypt_Detached_Internal(secretNonce: null, ciphertext: detachedBox.Cipher, mac: detachedBox.MessageAuthenticationCode, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Verifies and decrypts a detached box produced by Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt_Detached().
      /// </summary>
      /// <param name="detachedBox"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_decrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Decrypt_Detached(AEADBoxDetached detachedBox, byte[] publicNonce, byte[] key, string additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_IETF_Decrypt_Detached_Internal(secretNonce: null, ciphertext: detachedBox.Cipher, mac: detachedBox.MessageAuthenticationCode, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt(byte[] message, byte[] publicNonce, byte[] key, byte[] additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt(byte[] message, byte[] publicNonce, byte[] key, string additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt(string message, byte[] publicNonce, byte[] key, byte[] additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt(string message, byte[] publicNonce, byte[] key, string additionalData = null)
         => Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static AEADBoxDetached Crypto_AEAD_Chacha20Poly1305_Encrypt_Detached(byte[] message, byte[] publicNonce, byte[] key, byte[] additionalData = null)
      {
         JSObject jsObject = Crypto_AEAD_Chacha20Poly1305_IETF_Encrypt_Detached_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);
         return AEADBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static AEADBoxDetached Crypto_AEAD_Chacha20Poly1305_Encrypt_Detached(byte[] message, byte[] publicNonce, byte[] key, string additionalData = null)
      {
         JSObject jsObject = Crypto_AEAD_Chacha20Poly1305_IETF_Encrypt_Detached_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);
         return AEADBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static AEADBoxDetached Crypto_AEAD_Chacha20Poly1305_Encrypt_Detached(string message, byte[] publicNonce, byte[] key, byte[] additionalData = null)
      {
         JSObject jsObject = Crypto_AEAD_Chacha20Poly1305_IETF_Encrypt_Detached_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);
         return AEADBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static AEADBoxDetached Crypto_AEAD_Chacha20Poly1305_Encrypt_Detached(string message, byte[] publicNonce, byte[] key, string additionalData = null)
      {
         JSObject jsObject = Crypto_AEAD_Chacha20Poly1305_IETF_Encrypt_Detached_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);
         return AEADBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Randomly generate a key suitable for ChaCha20Poly1305_IETF.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_keygen.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_keygen", "blazorSodium")]
      public static partial byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_KeyGen();

      /// <summary>
      /// Randomly generate a key suitable for ChaCha20Poly1305.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_keygen.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_keygen", "blazorSodium")]
      public static partial byte[] Crypto_AEAD_ChaCha20Poly1305_KeyGen();

      /// <summary>
      /// Verifies and decrypts a ciphertext produced by Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt().
      /// </summary>
      /// <param name="ciphertext"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_decrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Decrypt(byte[] ciphertext, byte[] publicNonce, byte[] key, byte[] additionalData = null)
         => Crypto_AEAD_XChaCha20Poly1305_IETF_Decrypt_Internal(secretNonce: null, ciphertext: ciphertext, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Verifies and decrypts a ciphertext produced by Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt().
      /// </summary>
      /// <param name="ciphertext"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_decrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Decrypt(byte[] ciphertext, byte[] publicNonce, byte[] key, string additionalData = null)
         => Crypto_AEAD_XChaCha20Poly1305_IETF_Decrypt_Internal(secretNonce: null, ciphertext: ciphertext, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Verifies and decrypts a detached box produced by Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt_Detached().
      /// </summary>
      /// <param name="detachedBox"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_decrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Decrypt_Detached(AEADBoxDetached detachedBox, byte[] publicNonce, byte[] key, byte[] additionalData = null)
         => Crypto_AEAD_XChaCha20Poly1305_IETF_Decrypt_Detached_Internal(secretNonce: null, ciphertext: detachedBox.Cipher, mac: detachedBox.MessageAuthenticationCode, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Verifies and decrypts a detached box produced by Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt_Detached().
      /// </summary>
      /// <param name="detachedBox"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_decrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Decrypt_Detached(AEADBoxDetached detachedBox, byte[] publicNonce, byte[] key, string additionalData = null)
         => Crypto_AEAD_XChaCha20Poly1305_IETF_Decrypt_Detached_Internal(secretNonce: null, ciphertext: detachedBox.Cipher, mac: detachedBox.MessageAuthenticationCode, additionalData: additionalData, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt(byte[] message, byte[] publicNonce, byte[] key, byte[] additionalData = null)
         => Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt(byte[] message, byte[] publicNonce, byte[] key, string additionalData = null)
         => Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt(string message, byte[] publicNonce, byte[] key, byte[] additionalData = null)
         => Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt(string message, byte[] publicNonce, byte[] key, string additionalData = null)
         => Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static AEADBoxDetached Crypto_AEAD_XChacha20Poly1305_Encrypt_Detached(byte[] message, byte[] publicNonce, byte[] key, byte[] additionalData = null)
      {
         JSObject jsObject = Crypto_AEAD_XChacha20Poly1305_IETF_Encrypt_Detached_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);
         return AEADBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static AEADBoxDetached Crypto_AEAD_XChacha20Poly1305_Encrypt_Detached(byte[] message, byte[] publicNonce, byte[] key, string additionalData = null)
      {
         JSObject jsObject = Crypto_AEAD_XChacha20Poly1305_IETF_Encrypt_Detached_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);
         return AEADBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static AEADBoxDetached Crypto_AEAD_XChacha20Poly1305_Encrypt_Detached(string message, byte[] publicNonce, byte[] key, byte[] additionalData = null)
      {
         JSObject jsObject = Crypto_AEAD_XChacha20Poly1305_IETF_Encrypt_Detached_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);
         return AEADBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts a message using a secret key and public nonce.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <param name="additionalData">Optional.</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt_detached.json"/>
      [SupportedOSPlatform("browser")]
      public static AEADBoxDetached Crypto_AEAD_XChacha20Poly1305_Encrypt_Detached(string message, byte[] publicNonce, byte[] key, string additionalData = null)
      {
         JSObject jsObject = Crypto_AEAD_XChacha20Poly1305_IETF_Encrypt_Detached_Internal(message: message, additionalData: additionalData, secretNonce: null, publicNonce: publicNonce, key: key);
         return AEADBoxDetached.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Randomly generate a key suitable for XChaCha20Poly1305_IETF.
      /// </summary>
      /// <returns></returns>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_keygen", "blazorSodium")]
      public static partial byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_KeyGen();
   }
}
