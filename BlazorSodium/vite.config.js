import path from 'path';
import compression from 'vite-plugin-compression2';
import { defineConfig } from 'vite';

export default defineConfig({
    build: {
        target: 'esnext',
        minify: 'esbuild',
        lib: {
            entry: path.resolve(__dirname, 'Npm/src/blazorSodium.js'),
            formats: ['es'],
            fileName: 'blazorSodium.bundle',
        },
        outDir: path.resolve(__dirname, 'wwwroot'),
        sourcemap: false
    },
    plugins: [
        compression({
            algorithm: 'gzip',
            ext: /\.(js|css|html|svg)$/,
            exclude: [/\.(br)$/, /\.(gz)$/]
        }),
        compression({
            algorithm: 'brotliCompress',
            ext: /\.(js|css|html|svg)$/,
            exclude: [/\.(br)$/, /\.(gz)$/],
            options: { level: 11 }
        })
    ],
    resolve: {
        alias: {
            buffer: 'buffer/',
            crypto: 'crypto-browserify/',
            stream: 'stream-browserify/'
        }
    }
});