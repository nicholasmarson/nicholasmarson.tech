const path = require('path');

module.exports = {
  chainWebpack: (config) => {
    // Add a rule for handling PDF files
    config.module
      .rule('pdf')
      .test(/\.(pdf)(\?.*)?$/)
      .use('file-loader')
      .loader('file-loader')
      .options({
        name: 'assets/pdf/[name].[hash:8].[ext]',
      });
  },
};