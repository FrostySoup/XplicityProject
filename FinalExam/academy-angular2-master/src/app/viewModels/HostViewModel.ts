export class HostViewModel{
    hostId : number;
    name : string;
    state : number;
    processorCount : number;
    physicalMemory : PhysicalMemory;
}

export class PhysicalMemory{
    value : number;
    unit : number;
}

export class VirtualMachine {
    hostId : number;
    name: string;
    state: number;
    virtualProcessorCount : number;
    virtualMemory : number;
}