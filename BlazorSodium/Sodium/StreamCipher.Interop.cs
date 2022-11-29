using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   /* Missing from the sodium module
   public static partial class StreamCipher
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="outputLength"></param>
      /// <param name="key"></param>
      /// <param name="nonce"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20.json"/>
      [JSImport("sodium.crypto_stream_chacha20", "blazorSodium")]
      internal static partial byte[] Crypto_Stream_ChaCha20_Interop([JSMarshalAs<JSType.Number>] long outputLength, byte[] key, byte[] nonce);

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
      internal static partial byte[] Crypto_Stream_ChaCha20_IETF_XOR_IC_Interop(byte[] inputMessage, byte[] nonce, [JSMarshalAs<JSType.Number>] long nonceIncrement, byte[] key);

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
      internal static partial byte[] Crypto_Stream_ChaCha20_IETF_XOR_IC_Interop(string inputMessage, byte[] nonce, [JSMarshalAs<JSType.Number>] long nonceIncrement, byte[] key);

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
      internal static partial byte[] Crypto_Stream_ChaCha20_XOR_IC_Interop(byte[] inputMessage, byte[] nonce, [JSMarshalAs<JSType.Number>] long nonceIncrement, byte[] key);

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
      internal static partial byte[] Crypto_Stream_ChaCha20_XOR_IC_Interop(string inputMessage, byte[] nonce, [JSMarshalAs<JSType.Number>] long nonceIncrement, byte[] key);

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
      internal static partial byte[] Crypto_Stream_XChaCha20_XOR_IC_Interop(byte[] inputMessage, byte[] nonce, [JSMarshalAs<JSType.Number>] long nonceIncrement, byte[] key);

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
      internal static partial byte[] Crypto_Stream_XChaCha20_XOR_IC_Interop(string inputMessage, byte[] nonce, [JSMarshalAs<JSType.Number>] long nonceIncrement, byte[] key);
   }
   */
}
