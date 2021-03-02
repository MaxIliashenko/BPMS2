const path = require("path");
const htmlWebpack = require('html-webpack-plugin');

module.exports = {
    
    module: {
        rules: [
            {
                test: /\.(js|jsx)$/,
                exclude: /node_modules/,
                use: {
                    loader: "babel-loader"
                }
            },
            {
                test: /\.(sass|scss|css)$/,
                use: ['style-loader','css-loader','sass-loader']
            },
            {
                test: /\.(svg|eot|woff|woff2|ttf)$/,
                use: ['file-loader']
            }
        ]
    },
    
    output: {
        path: path.resolve(__dirname, '../wwwroot/js'),
        filename: "bpmsjslib.js",
        library: "BPMSJSLib"
    },
	
    plugins:[
        new htmlWebpack()
    ],

    performance: {
        maxEntrypointSize: 20000000,
        maxAssetSize: 20000000
    }
};