const path = require('path');
const CompressionPlugin = require('compression-webpack-plugin');
const TerserPlugin = require('terser-webpack-plugin');

module.exports = {
   name: 'blazorSodium',
   target: 'web',
   mode: 'production',
   experiments: {
      outputModule: true,
   },
   optimization: {
      minimize: true,
      minimizer: [
         new TerserPlugin({
            terserOptions: {
               compress: {
                  drop_console: false,
                  passes: 3
               },
               mangle: true
            }
         }),
      ],
   },
   output: {
      path: path.resolve(__dirname, 'wwwroot'),
      filename: 'blazorSodium.bundle.js',
      library: {
         type: 'module'
      }
   },
   plugins: [
      new CompressionPlugin({
         algorithm: 'gzip',
         test: /\.(js|css|html|svg)$/
      }),
      new CompressionPlugin({
         algorithm: 'brotliCompress',
         compressionOptions: { level: 11 },
         test: /\.(js|css|html|svg)$/
      })
   ],
   resolve: {
      fallback: {
         buffer: require.resolve('buffer/'),
         crypto: require.resolve('crypto-browserify/'),
         stream: require.resolve('stream-browserify/')
      }
   }
}
