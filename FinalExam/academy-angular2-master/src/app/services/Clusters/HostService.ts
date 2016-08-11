import {Http} from '@angular/http';

import {IReadOnlyService, ReadOnlyServiceBase} from '../ReadOnlyService';

import {IHost, Host} from '../../dtos/Host';

export class HostService 
    extends ReadOnlyServiceBase<IHost> {

    constructor(http: Http, baseUrl: string) {
        super(http, baseUrl);        
    }

    protected mapItem(data: any): IHost {
        return new Host(data);
    }
}