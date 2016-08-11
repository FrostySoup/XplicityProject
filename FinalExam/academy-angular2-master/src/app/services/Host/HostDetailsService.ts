import {Http} from '@angular/http';

import {IReadOnlyService, ReadOnlyServiceBase} from '../ReadOnlyService';

import {IVirtualMachine, VirtualMachine} from '../../dtos/VirtualMachine';

export class HostDetailService 
    extends ReadOnlyServiceBase<IVirtualMachine> {

    constructor(http: Http, baseUrl: string) {
        super(http, baseUrl);        
    }

    protected mapItem(data: any): IVirtualMachine {
        return new VirtualMachine(data);
    }
}