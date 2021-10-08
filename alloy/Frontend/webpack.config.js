const path = require('path');

module.exports = {
    entry: {
        // app: "./app.js",
        components: './src/expose-components.js'
    },
    output: {
        filename: 'components.bundle.js',
        path: path.resolve(__dirname + "/dist"),
        globalObject: 'this',
    },
    mode: "development",
    module: {
        rules: [
            {
                test: /\.(js|jsx)$/,
                exclude: /node_modules/,
                use: {
                    loader: 'babel-loader',
                }
            }
        ]
    },
    resolve: {
        extensions: ['*', '.js', '.jsx']
    },
    watch: true
}