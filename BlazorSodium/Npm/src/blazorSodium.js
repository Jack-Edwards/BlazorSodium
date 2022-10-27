export const sodium = require('libsodium-wrappers');

export async function init() {
   await sodium.ready;

   var usingWasm = typeof (sodium.libsodium.asm) === 'object'
      && typeof (sodium.libsodium.asm.__proto__) === 'undefined';

   console.log(`Sodium init: { version: ${sodium.sodium_version_string()}, wasm: ${usingWasm} }`);
}

export function getSodiumConstant(key) {
   return sodium[key];
}

export function printSodium() {
   console.log(sodium);
}
