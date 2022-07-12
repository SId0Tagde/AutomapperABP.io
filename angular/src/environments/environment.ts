import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Automapping',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44374',
    redirectUri: baseUrl,
    clientId: 'Automapping_App',
    responseType: 'code',
    scope: 'offline_access Automapping',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44374',
      rootNamespace: 'Automapping',
    },
  },
} as Environment;