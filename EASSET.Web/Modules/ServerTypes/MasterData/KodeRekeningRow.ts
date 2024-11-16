import { fieldsProxy } from "@serenity-is/corelib";

export interface KodeRekeningRow {
    Id?: number;
    Akun108Id?: string;
    AkunView?: string;
    Kelompok108Id?: string;
    KelompokView?: string;
    Jenis108Id?: string;
    JenisView?: string;
    Objek108Id?: string;
    ObjekView?: string;
    Ro108Id?: string;
    RoView?: string;
    SubRo108Id?: string;
    SubRoView?: string;
    SubSubRo108Id?: string;
    SubSubRoView?: string;
    KodeRekening108?: string;
    ThAng?: string;
    IsEnabled?: number;
}

export abstract class KodeRekeningRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Akun108Id';
    static readonly localTextPrefix = 'MasterData.KodeRekening';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<KodeRekeningRow>();
}