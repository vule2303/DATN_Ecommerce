import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'ClothingStore Admin',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:5000',
    redirectUri: baseUrl,
    clientId: 'ClothingStore_Admin',
    responseType: 'code',
    scope: 'offline_access ClothingStore.Admin',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:5001',
      rootNamespace: 'ClothingStore.Admin',
    },
  },
} as Environment;
