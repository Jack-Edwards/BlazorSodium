const path = require('path');

module.exports = {
   name: 'blazorSodium',
   target: 'web',
   experiments: {
      outputModule: true,
   },
   output: {
      path: path.resolve(__dirname, 'wwwroot'),
      filename: 'blazorSodium.bundle.js',
      library: {
         type: 'module'
      }
   },
   resolve: {
      fallback: {
         buffer: require.resolve('buffer/'),
         crypto: require.resolve('crypto-browserify/'),
         stream: require.resolve('stream-browserify/')
      }
   }
}
