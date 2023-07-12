using BlazorSodium.Sodium.Models;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class SecretStream
   {
      /// <summary>
      /// Initialize a stream for decryption using the provided header and key.
      /// </summary>
      /// <param name="header"></param>
      /// <param name="key"></param>
      /// <returns>
      /// Returns a state that must be provided to subsequent "pull" calls.
      /// </returns>
      public static StateAddress Crypto_SecretStream_XChaCha20Poly1305_Init_Pull(byte[] header, byte[] key)
      {
         int address = Crypto_SecretStream_XChaCha20Poly1305_Init_Pull_Interop(header, key);
         return new StateAddress(address);
      }

      /// <summary>
      /// Initialize an encrypted stream using the provided key.
      /// </summary>
      /// <param name="key"></param>
      /// <returns>
      /// Returns an object containing a "header" and the "state" of the initialized stream.
      /// The same header must be provided when initializating a corresponding decryption stream.
      /// The state must be provided to subsequent "push" calls.
      /// </returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretstream_xchacha20poly1305_init_push.json"/>
      public static SecretStreamPushData Crypto_SecretStream_XChaCha20Poly1305_Init_Push(byte[] key)
      {
         JSObject jsObject = Crypto_SecretStream_XChaCha20Poly1305_Init_Push_Interop(key);
         return SecretStreamPushData.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Randomly generate a key suitable for XChaCha20_Poly1305 encryption.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretstream_xchacha20poly1305_keygen.json"/>
      public static byte[] Crypto_SecretStream_XChaCha20Poly1305_KeyGen()
         => Crypto_SecretStream_XChaCha20Poly1305_KeyGen_Interop();

      /// <summary>
      /// Verifies the provided cipherChunk is valid for the provided state and optional additionalData.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="cipherChunk"></param>
      /// <param name="authenticatedData">Optional</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretstream_xchacha20poly1305_pull.json"/>
      public static SecretStreamPullData Crypto_SecretStream_XChaCha20Poly1305_Pull(StateAddress stateAddress, byte[] cipherChunk, byte[] authenticatedData = null)
      {
         JSObject jsObject = Crypto_SecretStream_XChaCha20Poly1305_Pull_Interop(stateAddress.Value, cipherChunk, authenticatedData);
         return SecretStreamPullData.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Encrypts the provided messageChunk using the provided state, authentication tag, and optional additionalData.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="messageChunk"></param>
      /// <param name="tag"></param>
      /// <param name="additionalData">Optional</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretstream_xchacha20poly1305_push.json"/>
      public static byte[] Crypto_SecretStream_XChaCha20Poly1305_Push(StateAddress stateAddress, byte[] messageChunk, uint tag = 0, byte[] additionalData = null)
         => Crypto_SecretStream_XChaCha20Poly1305_Push_Interop(stateAddress.Value, messageChunk, additionalData, tag);

      /// <summary>
      /// Encrypts the provided messageChunk using the provided state, authentication tag, and optional additionalData.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="messageChunk"></param>
      /// <param name="tag"></param>
      /// <param name="additionalData">Optional</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretstream_xchacha20poly1305_push.json"/>
      public static byte[] Crypto_SecretStream_XChaCha20Poly1305_Push(StateAddress stateAddress, string messageChunk, uint tag = 0, byte[] additionalData = null)
         => Crypto_SecretStream_XChaCha20Poly1305_Push_Interop(stateAddress.Value, messageChunk, additionalData, tag);

      /// <summary>
      /// Explicitly rekey the stream at the provided state.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretstream_xchacha20poly1305_rekey.json"/>
      public static void Crypto_SecretStream_XChaCha20Poly1305_ReKey(StateAddress stateAddress)
         => Crypto_SecretStream_XChaCha20Poly1305_ReKey_Interop(stateAddress.Value);
   }
}
