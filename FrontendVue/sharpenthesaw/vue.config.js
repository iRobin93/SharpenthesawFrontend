

const { defineConfig } = require('@vue/cli-service')
module.exports = defineConfig({
  transpileDependencies: true
})


module.exports = defineConfig({
  transpileDependencies: true,
  devServer: {
    proxy: {
      '/api': {
        target: 'https://sharpenthesawwebapp-a3ezc2gqbxavceg3.uksouth-01.azurewebsites.net',
        changeOrigin: true,
        secure: false,
      },
    },
  },
})