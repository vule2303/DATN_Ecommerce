import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'ClothingStore',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44376/',
    redirectUri: baseUrl,
    clientId: 'ClothingStore_App',
    responseType: 'code',
    scope: 'offline_access ClothingStore',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44356',
      rootNamespace: 'ClothingStore',
    },
  },
} as Environment;
