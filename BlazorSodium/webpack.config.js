const path = require('path');
const webpack = require('webpack');

module.exports = {
   name: 'blazorsodium-webpack-configuration',
   entry: './',
   mode: 'development',
   target: 'web',
   output: {
      path: path.resolve(__dirname, 'wwwroot'),
      filename: 'blazorSodium.bundle.js',
      libraryTarget: "var",
      library: "sodium",
   },
   resolve: {
      fallback: {
         buffer: require.resolve('buffer/'),
         crypto: require.resolve('crypto-browserify/'),
         stream: require.resolve('stream-browserify/')
      }
   }
}
