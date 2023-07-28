import path from 'path';
import { defineConfig } from 'vite';
import terser from '@rollup/plugin-terser';
import viteCompression from 'vite-plugin-compression';

export default defineConfig({
    build: {
        lib: {
            name: 'blazor-sodium',
            entry: path.join(__dirname, "Npm/src/blazorSodium.js"),
            fileName: (format) => `blazorSodium.${format}.js`
        },
        rollupOutputOptions: {
            plugins: [
                terser({
                    compress: {
                        drop_console: false,
                        passes: 3
                    },
                    mangle: true
                }),
                viteCompression({
                    algorithm: 'brotliCompress',
                    ext: 'br'
                }),
                viteCompression({
                    algorithm: 'gzip',
                    ext: 'gz',
                    compressionOptions: {
                        params: {
                            quality: 11
                        }
                    }
                })
            ]
        },
        resolve: {
            alias: {
                buffer: 'buffer/',
                crypto: 'crypto-browserify/',
                stream: 'stream-browserify/'
            }
        }
    }
});