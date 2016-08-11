import {Injectable} from '@angular/core';
import {Http} from '@angular/http';

import {HostDetailService} from './HostDetailsService';

import {IReadOnlyService} from '../ReadOnlyService';

import {IVirtualMachine} from '../../dtos/VirtualMachine';

export interface IVirtualMachineFactory {
    create(): IReadOnlyService<IVirtualMachine>;
}

@Injectable()
export class VirtualMachineFactory 
    implements IVirtualMachineFactory  {

    private _http: Http;

    constructor(http: Http) {
        this._http = http;
    }
        
    create(): IReadOnlyService<IVirtualMachine> {
        let url: string = `http://192.168.10.106/api/virtualmachines`;

        return new HostDetailService(this._http, url);
    }

}