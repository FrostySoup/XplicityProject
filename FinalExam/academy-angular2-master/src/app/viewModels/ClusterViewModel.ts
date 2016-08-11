export class Host{
    hostId : number;
    name : string;
    state : number;
    processorCount : number;
    physicalMemory : PhysicalMemory;
    clusterId : number;
}

export class PhysicalMemory{
    value : number;
    unit : number;
}

export class ClusterViewModel {
    clusterId : number;
    name: string;
    hostIds: number[];
}