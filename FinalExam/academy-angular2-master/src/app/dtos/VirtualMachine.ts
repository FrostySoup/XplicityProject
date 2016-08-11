export interface IVirtualMachine {
    hostId : number;
    name: string;
    state: number;
    virtualProcessorCount : number;
    virtualMemory : number;
}

export class VirtualMachine implements IVirtualMachine{
    hostId : number;
    name: string;
    state: number;
    virtualProcessorCount : number;
    virtualMemory : number;

    constructor(data: any) {
        this.hostId = data.hostId;
        this.name = data.name;
        this.state = data.state;
        this.virtualProcessorCount = data.virtualProcessorCount;
        this.virtualMemory = data.virtualMemory;
    }
}