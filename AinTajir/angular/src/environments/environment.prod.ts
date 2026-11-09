import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44309/',
  redirectUri: baseUrl,
  clientId: 'AinTajir_App',
  responseType: 'code',
  scope: 'offline_access AinTajir',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'AinTajir',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44309',
      rootNamespace: 'AinTajir',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
