import {bootstrap} from '@angular/platform-browser-dynamic';
import {enableProdMode} from '@angular/core';
import {HTTP_PROVIDERS} from '@angular/http';
import {provideForms, disableDeprecatedForms} from '@angular/forms';

import {AppComponent, environment} from './app/';

import {ComputerDetailsService} from './app/services/ComputerDetails/ComputerDetailsService';
import {ClusterDetailsService} from './app/services/Clusters/ClusterDetailsService';
import {UsageDataServiceFactory} from './app/services/ComputerDetails/UsageDataServiceFactory';
import {HostServiceFactory} from './app/services/Clusters/HostServiceFactory';
import {HostDetailsService} from './app/services/Host/HostDetailService';

import {APP_ROUTER_PROVIDERS} from './app/app.routes';

if (environment.production) {
  enableProdMode();
}

bootstrap(AppComponent, 
  [
    HTTP_PROVIDERS, 
    APP_ROUTER_PROVIDERS,
    ComputerDetailsService,
    ClusterDetailsService,
    UsageDataServiceFactory,
    HostServiceFactory,
    HostDetailsService,
    disableDeprecatedForms(), 
    provideForms()
    ]);
