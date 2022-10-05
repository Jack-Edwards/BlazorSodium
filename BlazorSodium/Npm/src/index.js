global._sodium = require('libsodium-wrappers');

(async () => {
   await global._sodium.ready;
   console.log("Sodium is ready!");
})();
