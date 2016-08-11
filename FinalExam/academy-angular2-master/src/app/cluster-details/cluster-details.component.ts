import { Component, OnInit } from '@angular/core';
import {Observable} from 'rxjs/Observable';
import {Router, ActivatedRoute, ROUTER_DIRECTIVES} from '@angular/router';

import {ClusterDetailsService} from '../services/Clusters/ClusterDetailsService';
import {HostServiceFactory, IHostServiceFactory} from '../services/Clusters/HostServiceFactory';

import {ClusterViewModel} from '../viewModels/ClusterViewModel';

import {ICluster} from '../dtos/Clusters';
import {IHost, Host} from '../dtos/Host';

@Component({
  moduleId: module.id,
  selector: 'cluster-details',
  templateUrl: 'cluster-details.component.html',
  styleUrls: ['cluster-details.component.css']
})
export class ClusterDetailsComponent implements OnInit {

  private _service: ClusterDetailsService;

  private _factory: IHostServiceFactory;

  clusterId: string;

  cluster: ICluster;

  host$: Observable<IHost[]>;

  filteredHosts: IHost[];

  private _router: Router;
  private _route: ActivatedRoute;

  constructor(service: ClusterDetailsService, factory: HostServiceFactory, route: ActivatedRoute, router: Router) {
    this._service = service;
    this._factory = factory;
    this._route = route;
    this._router = router;
   }

  ngOnInit() {
    this._route.params.subscribe(params => {
      this.clusterId = params['clusterId'];

      this.retrieveCluster();
    });
  }

  private retrieveCluster(): void {
    this._service.getItemById(this.clusterId).subscribe(cluster => {
      this.cluster = cluster;
      this.retrieveHost();
    } );
  }

 onNavigate(hostId : number): void {
    console.log(`Navigating to '${hostId}'...`);

    this._router.navigateByUrl(`host/${hostId}`);
  }

  private retrieveHost(): void {
      let service = this._factory.create();
      this.host$ = service.getAllItems();
      this.filteredHosts = [];
      this.host$.subscribe(hosts => {
      hosts.forEach(host => {
        if (host.clusterId+"" === this.clusterId)
          this.filteredHosts.push(host);
      });

      });

      //this.host$ = this.host$.filter(item => item === clusterId);
  }
}
