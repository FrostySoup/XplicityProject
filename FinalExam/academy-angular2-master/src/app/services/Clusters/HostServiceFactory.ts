import {Injectable} from '@angular/core';
import {Http} from '@angular/http';

import {HostService} from './HostService';

import {IReadOnlyService} from '../ReadOnlyService';

import {IHost} from '../../dtos/Host';

export interface IHostServiceFactory {
    create(): IReadOnlyService<IHost>;
}

@Injectable()
export class HostServiceFactory 
    implements IHostServiceFactory  {

    private _http: Http;

    constructor(http: Http) {
        this._http = http;
    }
        
    create(): IReadOnlyService<IHost> {
        let url: string = `http://192.168.10.106/api/hosts`;

        return new HostService(this._http, url);
    }

}