using BlazorSodium.Sodium.Models;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   public static partial class KeyExchange
   {
      /// <summary>
      /// 
      /// </summary>
      /// <param name="clientKeyPair"></param>
      /// <param name="serverPublicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_client_session_keys.json"/>
      [SupportedOSPlatform("browser")]
      public static SessionKeys Crypto_KX_Client_Session_Keys(X25519KeyPair clientKeyPair, byte[] serverPublicKey)
      {
         JSObject jsObject = Crypto_KX_Client_Session_Keys_Internal(clientKeyPair.PublicKey, clientKeyPair.PrivateKey, serverPublicKey);
         return SessionKeys.FromJavaScript(SessionKeysType.Client, jsObject);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="clientPublicKey"></param>
      /// <param name="clientSecretKey"></param>
      /// <param name="serverPublicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_client_session_keys.json"/>
      [JSImport("sodium.crypto_kx_client_session_keys", "blazorSodium")]
      internal static partial JSObject Crypto_KX_Client_Session_Keys_Internal(byte[] clientPublicKey, byte[] clientSecretKey, byte[] serverPublicKey);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="serverKeyPair"></param>
      /// <param name="clientPublicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_server_session_keys.json"/>
      [SupportedOSPlatform("browser")]
      public static SessionKeys Crypto_KX_Server_Session_Keys(X25519KeyPair serverKeyPair, byte[] clientPublicKey)
      {
         JSObject jsObject = Crypto_KX_Server_Session_Keys_Internal(serverKeyPair.PublicKey, serverKeyPair.PrivateKey, clientPublicKey);
         return SessionKeys.FromJavaScript(SessionKeysType.Server, jsObject);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="serverPublicKey"></param>
      /// <param name="serverSecretKey"></param>
      /// <param name="clientPublicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_server_session_keys.json"/>
      [JSImport("sodium.crypto_kx_server_session_keys", "blazorSodium")]
      internal static partial JSObject Crypto_KX_Server_Session_Keys_Internal(byte[] serverPublicKey, byte[] serverSecretKey, byte[] clientPublicKey);

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_keypair.json"/>
      [SupportedOSPlatform("browser")]
      public static X25519KeyPair Crypto_KX_KeyPair()
      {
         JSObject jsObject = Crypto_KX_KeyPair_Internal();
         return X25519KeyPair.FromJavaScript(jsObject);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_keypair.json"/>
      [JSImport("sodium.crypto_kx_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_KX_KeyPair_Internal();

      /// <summary>
      /// 
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_seed_keypair.json"/>
      [SupportedOSPlatform("browser")]
      public static X25519KeyPair Crypto_KX_Seed_KeyPair(byte[] seed)
      {
         JSObject jsObject = Crypto_KX_Seed_KeyPair_Internal(seed);
         return X25519KeyPair.FromJavaScript(jsObject);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_seed_keypair.json"/>
      [JSImport("sodium.crypto_kx_seed_keypair", "blazorSodium")]
      internal static partial JSObject Crypto_KX_Seed_KeyPair_Internal(byte[] seed);
   }
}
