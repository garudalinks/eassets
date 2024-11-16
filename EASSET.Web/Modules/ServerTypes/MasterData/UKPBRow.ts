import { fieldsProxy } from "@serenity-is/corelib";

export interface UKPBRow {
    Ukpbid?: string;
    Upbid?: string;
    UnitId?: string;
    SubUnitId?: string;
    UkpbKode?: string;
    UkpbNama?: string;
    UkpbAlamat?: string;
    ThAng?: string;
    Op?: string;
    Lu?: string;
    Pc?: string;
    Dlt?: number;
    UpbNama?: string;
    UnitNama?: string;
    SubUnitNama?: string;
}

export abstract class UKPBRow {
    static readonly idProperty = 'Ukpbid';
    static readonly nameProperty = 'UkpbNama';
    static readonly localTextPrefix = 'MasterData.UKPB';
    static readonly deletePermission = 'Ukpb:Delete';
    static readonly insertPermission = 'Ukpb:Insert';
    static readonly readPermission = 'Ukpb:View';
    static readonly updatePermission = 'Ukpb:Update';

    static readonly Fields = fieldsProxy<UKPBRow>();
}