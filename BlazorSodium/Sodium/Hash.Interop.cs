using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
    public static partial class Hash
    {
        /// <summary>
        /// Internal method.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_hash.json"/>
        [JSImport("sodium.crypto_hash", "blazorSodium")]
        internal static partial byte[] Crypto_Hash_Interop(byte[] message);

        /// <summary>
        /// Internal method.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <see cref="https://github.com/jedisct1/libsodium.js/blob/master/wrapper/symbols/crypto_hash.json"/>
        [JSImport("sodium.crypto_hash", "blazorSodium")]
        internal static partial byte[] Crypto_Hash_Interop(string message);


        [JSImport("sodium.crypto_hash_sha256", "blazorSodium")]
        internal static partial byte[] Crypto_Hash_Sha256_Interop(byte[] message);

    }
}
