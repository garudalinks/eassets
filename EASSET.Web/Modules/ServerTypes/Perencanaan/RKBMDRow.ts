import { fieldsProxy } from "@serenity-is/corelib";

export interface RKBMDRow {
    Rkbmdid?: string;
    UnitId?: string;
    NoUrut?: number;
    Keterangan?: string;
    ThAng?: string;
    Op?: string;
    Lu?: string;
    Pc?: string;
    Dlt?: number;
    SubUnitId?: string;
    SubKegId?: string;
    KodeRekening?: string;
    NamaRekening?: string;
    JmlUsulan?: number;
    JmlKebMax?: number;
    JmlExisting?: number;
    SubKegKode?: string;
    SubKegNama?: string;
    SubSubRo108Id?: string;
    Satuan?: string;
    Rkpdid?: string;
}

export abstract class RKBMDRow {
    static readonly idProperty = 'Rkbmdid';
    static readonly nameProperty = 'KodeRekening';
    static readonly localTextPrefix = 'Perencanaan.RKBMD';
    static readonly deletePermission = 'Rkbmd:Delete';
    static readonly insertPermission = 'Rkbmd:Insert';
    static readonly readPermission = 'Rkbmd:View';
    static readonly updatePermission = 'Rkbmd:Update';

    static readonly Fields = fieldsProxy<RKBMDRow>();
}