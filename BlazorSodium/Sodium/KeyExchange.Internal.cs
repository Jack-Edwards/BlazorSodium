using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public static partial class KeyExchange
   {
      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="clientPublicKey"></param>
      /// <param name="clientSecretKey"></param>
      /// <param name="serverPublicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_client_session_keys.json"/>
      [JSImport("sodium.crypto_kx_client_session_keys", "blazorSodium")]
      internal static partial JSObject Crypto_KX_Client_Session_Keys_Internal(byte[] clientPublicKey, byte[] clientSecretKey, byte[] serverPublicKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="serverPublicKey"></param>
      /// <param name="serverSecretKey"></param>
      /// <param name="clientPublicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_server_session_keys.json"/>
      [JSImport("sodium.crypto_kx_server_session_keys", "blazorSodium")]
      internal static partial JSObject Crypto_KX_Server_Session_Keys_Internal(byte[] serverPublicKey, byte[] serverSecretKey, byte[] clientPublicKey);

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_keypair.json"/>
      [JSImport("sodium.crypto_kx_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_KX_KeyPair_Internal();

      /// <summary>
      /// Internal method.
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_seed_keypair.json"/>
      [JSImport("sodium.crypto_kx_seed_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_KX_Seed_KeyPair_Internal(byte[] seed);
   }
}
