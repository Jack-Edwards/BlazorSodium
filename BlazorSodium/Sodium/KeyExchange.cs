using BlazorSodium.Sodium.Models;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace BlazorSodium.Sodium
{
   [SupportedOSPlatform("browser")]
   public static partial class KeyExchange
   {
      /// <summary>
      /// Computes a pair of secret keys to share data between a client and server.
      /// </summary>
      /// <param name="clientKeyPair"></param>
      /// <param name="serverPublicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_client_session_keys.json"/>
      public static SessionKeys Crypto_KX_Client_Session_Keys(X25519KeyPair clientKeyPair, byte[] serverPublicKey)
      {
         JSObject jsObject = Crypto_KX_Client_Session_Keys_Interop(clientKeyPair.PublicKey, clientKeyPair.PrivateKey, serverPublicKey);
         return SessionKeys.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Computes a pair of secret keys to share data between a client and server.
      /// </summary>
      /// <param name="serverKeyPair"></param>
      /// <param name="clientPublicKey"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_server_session_keys.json"/>
      public static SessionKeys Crypto_KX_Server_Session_Keys(X25519KeyPair serverKeyPair, byte[] clientPublicKey)
      {
         JSObject jsObject = Crypto_KX_Server_Session_Keys_Interop(serverKeyPair.PublicKey, serverKeyPair.PrivateKey, clientPublicKey);
         return SessionKeys.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Randomly generate an X25519 key pair.
      /// </summary>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_keypair.json"/>
      public static X25519KeyPair Crypto_KX_KeyPair()
      {
         JSObject jsObject = Crypto_KX_KeyPair_Interop();
         return X25519KeyPair.FromJavaScript(jsObject);
      }

      /// <summary>
      /// Derive an X25519 key pair from a seed.
      /// </summary>
      /// <param name="seed"></param>
      /// <returns></returns>
      /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_kx_seed_keypair.json"/>
      public static X25519KeyPair Crypto_KX_Seed_KeyPair(byte[] seed)
      {
         JSObject jsObject = Crypto_KX_Seed_KeyPair_Interop(seed);
         return X25519KeyPair.FromJavaScript(jsObject);
      }
   }
}
