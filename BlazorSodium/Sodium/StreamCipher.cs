using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class StreamCipher
   {
      /// <summary>
      /// 
      /// </summary>
      /// <param name="outLength"></param>
      /// <param name="key"></param>
      /// <param name="nonce"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20.json"/>
      [JSImport("sodium.crypto_stream_chacha20", "blazorSodium")]
      public static partial byte[] Crypto_Stream_Chacha20(int outLength, byte[] key, byte[] nonce);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="input_message"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_ietf_xor.json"/>
      [JSImport("sodium.crypto_stream_chacha20_ietf_xor", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_IETF_XOR(byte[] input_message, byte[] nonce, byte[] key);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="input_message"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_ietf_xor.json"/>
      [JSImport("sodium.crypto_stream_chacha20_ietf_xor", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_IETF_XOR(string input_message, byte[] nonce, byte[] key);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="input_message"></param>
      /// <param name="nonce"></param>
      /// <param name="nonce_increment"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_ietf_xor_ic.json"/>
      [JSImport("sodium.crypto_stream_chacha20_ietf_xor_ic", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_IETF_XOR_IC(byte[] input_message, byte[] nonce, int nonce_increment, byte[] key);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="input_message"></param>
      /// <param name="nonce"></param>
      /// <param name="nonce_increment"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_ietf_xor_ic.json"/>
      [JSImport("sodium.crypto_stream_chacha20_ietf_xor_ic", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_IETF_XOR_IC(string input_message, byte[] nonce, int nonce_increment, byte[] key);


      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_keygen.json"/>
      [JSImport("sodium.crypto_stream_chacha20_keygen", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_KeyGen();

      /// <summary>
      /// 
      /// </summary>
      /// <param name="input_message"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_xor.json"/>
      [JSImport("sodium.crypto_stream_chacha20_xor", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_XOR(byte[] input_message, byte[] nonce, byte[] key);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="input_message"></param>
      /// <param name="nonce"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_xor.json"/>
      [JSImport("sodium.crypto_stream_chacha20_xor", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_XOR(string input_message, byte[] nonce, byte[] key);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="input_message"></param>
      /// <param name="nonce"></param>
      /// <param name="nonce_increment"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_xor_ic.json"/>
      [JSImport("sodium.crypto_stream_chacha20_xor_ic", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_XOR_IC(byte[] input_message, byte[] nonce, int nonce_increment, byte[] key);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="input_message"></param>
      /// <param name="nonce"></param>
      /// <param name="nonce_increment"></param>
      /// <param name="key"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_stream_chacha20_xor_ic.json"/>
      [JSImport("sodium.crypto_stream_chacha20_xor_ic", "blazorSodium")]
      public static partial byte[] Crypto_Stream_ChaCha20_XOR_IC(string input_message, byte[] nonce, int nonce_increment, byte[] key);
   }
}
