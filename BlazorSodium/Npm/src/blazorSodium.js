export const sodium = require('libsodium-wrappers');

export async function blazorSodiumInit() {
   await sodium.ready;
   console.log(`Using sodium version: ${sodium.sodium_version_string()}`);

   var usingWasm = typeof (sodium.libsodium.asm) === 'object'
      && typeof (sodium.libsodium.asm.__proto__) === 'undefined';
   console.log(`Sodium is using wasm: ${usingWasm}`);
}
