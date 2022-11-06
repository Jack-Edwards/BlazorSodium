export const libsodium = require('libsodium-sumo');
export const sodium = require('libsodium-wrappers');
export const sodium_wrappers_sumo = require('libsodium-wrappers-sumo')

export async function init() {
   await libsodium.ready;
   await sodium.ready;
   await sodium_wrappers_sumo.ready;

   var libsodiumUsingWasm = typeof (libsodium.asm) === 'object'
      && typeof (libsodium.asm.__proto__) === 'undefined';
   console.log(`libsodium init: { version: ${libsodium._sodium_version_string()}, wasm: ${libsodiumUsingWasm} }`);

   var libsodiumWrappersUsingWasm = typeof (sodium.asm) === 'object'
      && typeof (sodium.asm.__proto__) === 'undefined';
   console.log(`sodium init: { version: ${sodium.sodium_version_string()}, wasm: ${libsodiumWrappersUsingWasm} }`);
}

export function getSodiumConstant(key) {
   return sodium[key];
}

export function printSodium() {
   console.log(libsodium);
   console.log(sodium);
   console.log(sodium_wrappers_sumo);
}

export function cryptoShortHashPointers(hashAddress, messageAddress, messageLength, something, keyAddress) {
   return libsodium._crypto_shorthash(hashAddress, messageAddress, messageLength, something, keyAddress);
}

export function cryptoShortHashMemoryView(hashBuffer, messageBuffer, keyBuffer) {
   hashBuffer.set(sodium.crypto_shorthash(messageBuffer.slice(), keyBuffer.slice()));
}

export function cryptoShortHashMemoryView_2(hashBuffer, message, key) {
   hashBuffer.set(sodium.crypto_shorthash(message, key));
}

export function randomBytes_MemoryViewTest(size, buffer) {
   buffer.set(sodium.randombytes_buf(size));
}
