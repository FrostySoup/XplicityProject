import { Component, OnInit } from '@angular/core';
import {Observable} from 'rxjs/Observable';
import {Router, ActivatedRoute, ROUTER_DIRECTIVES} from '@angular/router';

import {HostDetailsService} from '../services/Host/HostDetailService';
import {VirtualMachineFactory, IVirtualMachineFactory} from '../services/Host/VirtualMachineFactory';

import {HostViewModel} from '../viewModels/HostViewModel';

import {IHost} from '../dtos/Host';
import {IVirtualMachine, VirtualMachine} from '../dtos/VirtualMachine';

@Component({
  moduleId: module.id,
  selector: 'host-details',
  templateUrl: 'host-details.component.html',
  styleUrls: ['host-details.component.css']
})
export class HostDetailsComponent implements OnInit {
  ngOnInit() {
  }
/*
  private _service: HostDetailsService;

  private _factory: IVirtualMachineFactory;

  hostId: string;

  host: IHost;

  virtualMachines$: Observable<IVirtualMachine[]>;

  filteredMachines: IVirtualMachine[];

  private _router: Router;
  private _route: ActivatedRoute;

  constructor(service: HostDetailsService, factory: VirtualMachineFactory, route: ActivatedRoute, router: Router) {
    this._service = service;
    this._factory = factory;
    this._route = route;
    this._router = router;
   }

  ngOnInit() {
    this._route.params.subscribe(params => {
      this.hostId = params['hostId'];

      this.retrieveCluster();
    });
  }

  private retrieveCluster(): void {
    this._service.getItemById(this.hostId).subscribe(host => {
      this.host = host;
      this.retrieveHost();
    } );
  }

  private retrieveHost(): void {
      let service = this._factory.create();
      this.virtualMachines$ = service.getAllItems();

      this.filteredMachines = [];

      this.virtualMachines$.subscribe(hosts => {
      hosts.forEach(host => {
        if (host.hostId+"" === this.hostId)
          this.filteredMachines.push(host);
      });

      });
  }*/
}
