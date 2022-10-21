using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   public static partial class StreamCipher
   {
      /// <summary>
      /// Return an array of psuedorandom bytes, of the provided length, using the provided key and nonce.
      /// </summary>
      /// <param name="outputLength"></param>
      /// <param name="key"></param>
      /// <param name="nonce"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_Stream_ChaCha20(uint outputLength, byte[] key, byte[] nonce)
         => Crypto_Stream_ChaCha20_Internal(outputLength, key, nonce);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="outputLength"></param>
      /// <param name="key"></param>
      /// <param name="nonce"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20.json"/>
      [JSImport("sodium.crypto_stream_chacha20", "blazorSodium")]
      internal static partial byte[] Crypto_Stream_ChaCha20_Internal([JSMarshalAs<JSType.Number>] long outputLength, byte[] key, byte[] nonce);

      /// <summary>
      /// Encrypt a message using the provided key and nonce.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_ietf_xor.json"/>
      [JSImport("sodium.crypto_stream_chacha20_ietf_xor", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_IETF_XOR(byte[] inputMessage, byte[] nonce, byte[] key);

      /// <summary>
      /// Encrypt a message using the provided key and nonce.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_ietf_xor.json"/>
      [JSImport("sodium.crypto_stream_chacha20_ietf_xor", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_IETF_XOR(string inputMessage, byte[] nonce, byte[] key);

      /// <summary>
      /// Encrypt a message using the provided key and nonce, with the ability to provide an initial value for the block counter.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="nonceIncrement"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_ietf_xor_ic.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_Stream_ChaCha20_IETF_XOR_IC(byte[] inputMessage, byte[] nonce, uint nonceIncrement, byte[] key)
         => Crypto_Stream_ChaCha20_IETF_XOR_IC_Internal(inputMessage, nonce, nonceIncrement, key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="nonceIncrement"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_ietf_xor_ic.json"/>
      [JSImport("sodium.crypto_stream_chacha20_ietf_xor_ic", "blazorSodium")]
      internal static partial byte[] Crypto_Stream_ChaCha20_IETF_XOR_IC_Internal(byte[] inputMessage, byte[] nonce, [JSMarshalAs<JSType.Number>] long nonceIncrement, byte[] key);

      /// <summary>
      /// Encrypt a message using the provided key and nonce, with the ability to provide an initial value for the block counter.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="nonceIncrement"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_ietf_xor_ic.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_Stream_ChaCha20_IETF_XOR_IC(string inputMessage, byte[] nonce, uint nonceIncrement, byte[] key)
         => Crypto_Stream_ChaCha20_IETF_XOR_IC_Internal(inputMessage, nonce, nonceIncrement, key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="nonceIncrement"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_ietf_xor_ic.json"/>
      [JSImport("sodium.crypto_stream_chacha20_ietf_xor_ic", "blazorSodium")]
      internal static partial byte[] Crypto_Stream_ChaCha20_IETF_XOR_IC_Internal(string inputMessage, byte[] nonce, [JSMarshalAs<JSType.Number>] long nonceIncrement, byte[] key);

      /// <summary>
      /// Randomly generate a secret key suitable for ChaCha20.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_keygen.json"/>
      [JSImport("sodium.crypto_stream_chacha20_keygen", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_KeyGen();

      /// <summary>
      /// Encrypt a message using the provided key and nonce.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_xor.json"/>
      [JSImport("sodium.crypto_stream_chacha20_xor", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_XOR(byte[] inputMessage, byte[] nonce, byte[] key);

      /// <summary>
      /// Encrypt a message using the provided key and nonce.
      /// </summary>
      /// <param name="input_message"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_xor.json"/>
      [JSImport("sodium.crypto_stream_chacha20_xor", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_XOR(string inputMessage, byte[] nonce, byte[] key);

      /// <summary>
      /// Encrypt a message using the provided key and nonce, with the ability to provide an initial value for the block counter.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="nonceIncrement"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_xor_ic.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_Stream_ChaCha20_XOR_IC(byte[] inputMessage, byte[] nonce, uint nonceIncrement, byte[] key)
         => Crypto_Stream_ChaCha20_IETF_XOR_IC_Internal(inputMessage, nonce, nonceIncrement, key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="nonceIncrement"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_xor_ic.json"/>
      [JSImport("sodium.crypto_stream_chacha20_xor_ic", "blazorSodium")]
      internal static partial byte[] Crypto_Stream_ChaCha20_XOR_IC_Internal(byte[] inputMessage, byte[] nonce, [JSMarshalAs<JSType.Number>] long nonceIncrement, byte[] key);

      /// <summary>
      /// Encrypt a message using the provided key and nonce, with the ability to provide an initial value for the block counter.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="nonceIncrement"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_xor_ic.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_Stream_ChaCha20_XOR_IC(string inputMessage, byte[] nonce, uint nonceIncrement, byte[] key)
         => Crypto_Stream_ChaCha20_XOR_IC_Internal(inputMessage, nonce, nonceIncrement, key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="nonceIncrement"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_xor_ic.json"/>
      [JSImport("sodium.crypto_stream_chacha20_xor_ic", "blazorSodium")]
      internal static partial byte[] Crypto_Stream_ChaCha20_XOR_IC_Internal(string inputMessage, byte[] nonce, [JSMarshalAs<JSType.Number>] long nonceIncrement, byte[] key);

      /// <summary>
      /// Randomly generate a secret key suitable for XChaCha20.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_xchacha20_keygen.json"/>
      [JSImport("sodium.crypto_stream_xchacha20_keygen", "blazorSodium")]
      public static partial byte[] Crypto_Stream_XChaCha20_KeyGen();

      /// <summary>
      /// Encrypt a message using the provided key and nonce.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_xchacha20_xor.json"/>
      [JSImport("sodium.crypto_stream_xchacha20_xor", "blazorSodium")]
      public static partial byte[] Crypto_Stream_XChaCha20_XOR(byte[] inputMessage, byte[] nonce, byte[] key);

      /// <summary>
      /// Encrypt a message using the provided key and nonce.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_xchacha20_xor.json"/>
      [JSImport("sodium.crypto_stream_xchacha20_xor", "blazorSodium")]
      public static partial byte[] Crypto_Stream_XChaCha20_XOR(string inputMessage, byte[] nonce, byte[] key);

      /// <summary>
      /// Encrypt a message using the provided key and nonce, with the ability to provide an initial value for the block counter.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="nonceIncrement"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_xchacha20_xor_ic.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_Stream_XChaCha20_XOR_IC(byte[] inputMessage, byte[] nonce, uint nonceIncrement, byte[] key)
         => Crypto_Stream_XChaCha20_XOR_IC_Internal(inputMessage, nonce, nonceIncrement, key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="nonceIncrement"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_xchacha20_xor_ic.json"/>
      [JSImport("sodium.crypto_stream_xchacha20_xor_ic", "blazorSodium")]
      internal static partial byte[] Crypto_Stream_XChaCha20_XOR_IC_Internal(byte[] inputMessage, byte[] nonce, [JSMarshalAs<JSType.Number>] long nonceIncrement, byte[] key);

      /// <summary>
      /// Encrypt a message using the provided key and nonce, with the ability to provide an initial value for the block counter.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="nonceIncrement"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_xchacha20_xor_ic.json"/>
      [SupportedOSPlatform("browser")]
      public static byte[] Crypto_Stream_XChaCha20_XOR_IC(string inputMessage, byte[] nonce, uint nonceIncrement, byte[] key)
         => Crypto_Stream_XChaCha20_XOR_IC_Internal(inputMessage, nonce, nonceIncrement, key);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="inputMessage"></param>
      /// <param name="nonce"></param>
      /// <param name="nonceIncrement"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_xchacha20_xor_ic.json"/>
      [JSImport("sodium.crypto_stream_xchacha20_xor_ic", "blazorSodium")]
      internal static partial byte[] Crypto_Stream_XChaCha20_XOR_IC_Internal(string inputMessage, byte[] nonce, [JSMarshalAs<JSType.Number>] long nonceIncrement, byte[] key);
   }
}
