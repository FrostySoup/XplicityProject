import { Component, OnInit } from '@angular/core';
import {Observable} from 'rxjs/Observable';
import {Router} from '@angular/router';

import {ClusterDetailsService} from '../services/Clusters/ClusterDetailsService';

import {ClusterViewModel} from '../viewModels/ClusterViewModel';

import {ICluster} from '../dtos/Clusters';

@Component({
  moduleId: module.id,
  selector: 'app-cluster-list',
  templateUrl: 'clusters.component.html',
  styleUrls: ['clusters.component.css']
})
export class ClusterListComponent implements OnInit {

  private _service: ClusterDetailsService;
  private _router: Router;

  clusters$: Observable<ICluster[]>;

  constructor(service:ClusterDetailsService, router: Router) {
    this._service = service;
    this._router = router;
    this.clusters$ = service.getAllItems();
   }

  ngOnInit() {
  }

  onNavigate(cluster: ClusterViewModel): void {
    console.log(`Navigating to '${cluster.clusterId}'...`);

    this._router.navigateByUrl(`clusters/${cluster.clusterId}`);
  }


}
