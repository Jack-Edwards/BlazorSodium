const path = require('path');
const webpack = require('webpack');

module.exports = {
   name: 'blazorsodium-webpack-configuration',
   entry: './',
   mode: 'development',
   target: 'web',
   output: {
      path: path.resolve(__dirname, 'wwwroot/js'),
      filename: '[name].js'
   },
   resolve: {
      fallback: {
         buffer: require.resolve('buffer/'),
         crypto: require.resolve('crypto-browserify/'),
         stream: require.resolve('stream-browserify/')
      }
   },
}
