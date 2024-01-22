using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class AEAD
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="ciphertext"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_decrypt.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_decrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_Decrypt_Interop(byte[]? secretNonce, byte[] ciphertext, byte[]? additionalData, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="ciphertext"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_decrypt.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_decrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_Decrypt_Interop(byte[]? secretNonce, byte[] ciphertext, string? additionalData, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="ciphertext"></param>
      /// <param name="mac"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_decrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_decrypt_detached", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_Decrypt_Detached_Interop(byte[]? secretNonce, byte[] ciphertext, byte[] mac, byte[]? additionalData, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="ciphertext"></param>
      /// <param name="mac"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_decrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_decrypt_detached", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_Decrypt_Detached_Interop(byte[]? secretNonce, byte[] ciphertext, byte[] mac, string? additionalData, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_encrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_Encrypt_Interop(byte[] message, byte[]? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_encrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_Encrypt_Interop(byte[] message, string? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_encrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_Encrypt_Interop(string message, byte[]? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_encrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_Encrypt_Interop(string message, string? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_encrypt_detached", "blazorSodium")]
      internal static partial JSObject Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached_Interop(byte[] message, byte[]? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_encrypt_detached", "blazorSodium")]
      internal static partial JSObject Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached_Interop(byte[] message, string? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_encrypt_detached", "blazorSodium")]
      internal static partial JSObject Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached_Interop(string message, byte[]? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_encrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_encrypt_detached", "blazorSodium")]
      internal static partial JSObject Crypto_AEAD_ChaCha20Poly1305_Encrypt_Detached_Interop(string message, string? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="ciphertext"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_decrypt.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_decrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Decrypt_Interop(byte[]? secretNonce, byte[] ciphertext, byte[]? additionalData, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="ciphertext"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_decrypt.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_decrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Decrypt_Interop(byte[]? secretNonce, byte[] ciphertext, string? additionalData, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="ciphertext"></param>
      /// <param name="mac"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_decrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_decrypt_detached", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Decrypt_Detached_Interop(byte[]? secretNonce, byte[] ciphertext, byte[] mac, byte[]? additionalData, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="ciphertext"></param>
      /// <param name="mac"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_decrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_decrypt_detached", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Decrypt_Detached_Interop(byte[]? secretNonce, byte[] ciphertext, byte[] mac, string? additionalData, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_encrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt_Interop(byte[] message, byte[]? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_encrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt_Interop(byte[] message, string? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_encrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt_Interop(string message, byte[]? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_encrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_Encrypt_Interop(string message, string? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>Internal method.
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_encrypt_detached", "blazorSodium")]
      internal static partial JSObject Crypto_AEAD_Chacha20Poly1305_IETF_Encrypt_Detached_Interop(byte[] message, byte[]? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>Internal method.
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_encrypt_detached", "blazorSodium")]
      internal static partial JSObject Crypto_AEAD_Chacha20Poly1305_IETF_Encrypt_Detached_Interop(byte[] message, string? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>Internal method.
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_encrypt_detached", "blazorSodium")]
      internal static partial JSObject Crypto_AEAD_Chacha20Poly1305_IETF_Encrypt_Detached_Interop(string message, byte[]? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>Internal method.
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_encrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_encrypt_detached", "blazorSodium")]
      internal static partial JSObject Crypto_AEAD_Chacha20Poly1305_IETF_Encrypt_Detached_Interop(string message, string? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_ietf_keygen.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_ietf_keygen", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_IETF_KeyGen_Interop();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_chacha20poly1305_keygen.json"/>
      [JSImport("sodium.crypto_aead_chacha20poly1305_keygen", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_ChaCha20Poly1305_KeyGen_Interop();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="ciphertext"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_decrypt.json"/>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_decrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Decrypt_Interop(byte[]? secretNonce, byte[] ciphertext, byte[]? additionalData, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="ciphertext"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_decrypt.json"/>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_decrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Decrypt_Interop(byte[]? secretNonce, byte[] ciphertext, string? additionalData, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="ciphertext"></param>
      /// <param name="mac"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_decrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_decrypt_detached", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Decrypt_Detached_Interop(byte[]? secretNonce, byte[] ciphertext, byte[] mac, byte[]? additionalData, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="ciphertext"></param>
      /// <param name="mac"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_decrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_decrypt_detached", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Decrypt_Detached_Interop(byte[]? secretNonce, byte[] ciphertext, byte[] mac, string? additionalData, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt.json"/>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_encrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt_Interop(byte[] message, byte[]? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt.json"/>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_encrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt_Interop(byte[] message, string? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt.json"/>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_encrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt_Interop(string message, byte[]? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt.json"/>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_encrypt", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_Encrypt_Interop(string message, string? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_encrypt_detached", "blazorSodium")]
      internal static partial JSObject Crypto_AEAD_XChacha20Poly1305_IETF_Encrypt_Detached_Interop(byte[] message, byte[]? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_encrypt_detached", "blazorSodium")]
      internal static partial JSObject Crypto_AEAD_XChacha20Poly1305_IETF_Encrypt_Detached_Interop(byte[] message, string? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_encrypt_detached", "blazorSodium")]
      internal static partial JSObject Crypto_AEAD_XChacha20Poly1305_IETF_Encrypt_Detached_Interop(string message, byte[]? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="message"></param>
      /// <param name="additionalData">Optional.</param>
      /// <param name="secretNonce">The documentation states this should always be null.</param>
      /// <param name="publicNonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_aead_xchacha20poly1305_ietf_encrypt_detached.json"/>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_encrypt_detached", "blazorSodium")]
      internal static partial JSObject Crypto_AEAD_XChacha20Poly1305_IETF_Encrypt_Detached_Interop(string message, string? additionalData, byte[]? secretNonce, byte[] publicNonce, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      [JSImport("sodium.crypto_aead_xchacha20poly1305_ietf_keygen", "blazorSodium")]
      internal static partial byte[] Crypto_AEAD_XChaCha20Poly1305_IETF_KeyGen_Interop();
   }
}
