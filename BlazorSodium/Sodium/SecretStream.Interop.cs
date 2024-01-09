using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class SecretStream
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="header"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretstream_xchacha20poly1305_init_pull.json"/>
      [JSImport("sodium.crypto_secretstream_xchacha20poly1305_init_pull", "blazorSodium")]
      internal static partial int Crypto_SecretStream_XChaCha20Poly1305_Init_Pull_Interop(byte[] header, byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretstream_xchacha20poly1305_init_push.json"/>
      [JSImport("sodium.crypto_secretstream_xchacha20poly1305_init_push", "blazorSodium")]
      internal static partial JSObject Crypto_SecretStream_XChaCha20Poly1305_Init_Push_Interop(byte[] key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretstream_xchacha20poly1305_keygen.json"/>
      [JSImport("sodium.crypto_secretstream_xchacha20poly1305_keygen", "blazorSodium")]
      internal static partial byte[] Crypto_SecretStream_XChaCha20Poly1305_KeyGen_Interop();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="cipherChunk"></param>
      /// <param name="additionalData">Optional</param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretstream_xchacha20poly1305_pull.json"/>
      [JSImport("sodium.crypto_secretstream_xchacha20poly1305_pull", "blazorSodium")]
      internal static partial JSObject Crypto_SecretStream_XChaCha20Poly1305_Pull_Interop([JSMarshalAsAttribute<JSType.Number>] long stateAddress, byte[] cipherChunk, byte[]? additionalData);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="messageChunk"></param>
      /// <param name="additionalData">Optional</param>
      /// <param name="tag"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretstream_xchacha20poly1305_push.json"/>
      [JSImport("sodium.crypto_secretstream_xchacha20poly1305_push", "blazorSodium")]
      internal static partial byte[] Crypto_SecretStream_XChaCha20Poly1305_Push_Interop([JSMarshalAsAttribute<JSType.Number>] long stateAddress, byte[] messageChunk, byte[]? additionalData, [JSMarshalAsAttribute<JSType.Number>] long tag);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <param name="messageChunk"></param>
      /// <param name="additionalData">Optional</param>
      /// <param name="tag"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretstream_xchacha20poly1305_push.json"/>
      [JSImport("sodium.crypto_secretstream_xchacha20poly1305_push", "blazorSodium")]
      internal static partial byte[] Crypto_SecretStream_XChaCha20Poly1305_Push_Interop([JSMarshalAsAttribute<JSType.Number>] long stateAddress, string messageChunk, byte[]? additionalData, [JSMarshalAsAttribute<JSType.Number>] long tag);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="stateAddress"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_secretstream_xchacha20poly1305_rekey.json"/>
      [JSImport("sodium.crypto_secretstream_xchacha20poly1305_rekey", "blazorSodium")]
      internal static partial byte[] Crypto_SecretStream_XChaCha20Poly1305_ReKey_Interop([JSMarshalAsAttribute<JSType.Number>] long stateAddress);
   }
}
