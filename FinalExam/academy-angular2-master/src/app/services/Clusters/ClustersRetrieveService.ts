/*import {Observable} from 'rxjs/Observable';
import {Subject} from 'rxjs/Subject';
import 'rxjs/add/observable/from';

import {IReadOnlyService} from '../ReadOnlyService';
import {ClusterViewModel} from '../../viewModels/ClusterViewModel';

export class ClusterRetrieveService {
    
    private _clusters: ClusterViewModel[];

    constructor() {    
    }

    getAllItems(): Observable<ClusterViewModel[]> {
        return Observable.from([this._clusters]);
    }

    getItemById(clusterId: number): Observable<ClusterViewModel> {
        let match = this._clusters.filter(c => c.clusterId == clusterId);

        return Observable.from(match);
    }
}*/