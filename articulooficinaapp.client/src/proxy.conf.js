const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
    env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:5190';

const PROXY_CONFIG = [
  {
    context: [
      "/api/articulos/obtenerTodos",
    ],
    target,
    secure: false
  },


]

module.exports = PROXY_CONFIG;
