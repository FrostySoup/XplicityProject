export interface IHost {
    hostId : number;
    name : string;
    state : number;
    processorCount : number;
    physicalMemory : PhysicalMemory;
    clusterId : number;
}

export class Host implements IHost{
    hostId : number;
    name : string;
    state : number;
    processorCount : number;
    physicalMemory : PhysicalMemory;
    clusterId : number;
    
    constructor(data: any) {
        this.name = data.name;
        this.state = data.state;
        this.processorCount = data.processorCount;
        this.physicalMemory = data.physicalMemory;
        this.clusterId = data.clusterId;
        this.hostId = data.hostId;
    }
}

export class PhysicalMemory{
    value : number;
    unit : number;
}