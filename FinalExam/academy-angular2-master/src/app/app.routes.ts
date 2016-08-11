import {provideRouter, Route} from '@angular/router';

import {WelcomePageComponent} from './welcome-page/welcome-page.component';
import {ComputerListComponent} from './computer-list/computer-list.component';
import {ComputerDetailsComponent} from './computer-details/computer-details.component';
import {TestpageComponent} from './testpage/testpage.component';
import {ClusterListComponent} from './clusters/clusters.component';
import {ClusterDetailsComponent} from './cluster-details/cluster-details.component';
import {HostDetailsComponent} from './host-details/host-details.component';

export const routes: Route[] = [
  { path: '',   component: WelcomePageComponent },
  { path: 'computers', component: ComputerListComponent },
  { path: 'computers/:computerId', component: ComputerDetailsComponent },
  { path: 'testpage', component: TestpageComponent },
  { path: 'clusters', component: ClusterListComponent },
  { path: 'clusters/:clusterId', component: ClusterDetailsComponent },
  { path: 'host/:hostId', component: HostDetailsComponent }
];

export const APP_ROUTER_PROVIDERS = [
  provideRouter(routes)
];