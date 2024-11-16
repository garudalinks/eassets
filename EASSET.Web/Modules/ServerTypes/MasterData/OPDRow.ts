import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface OPDRow {
    UnitId?: string;
    UnitKode?: string;
    UnitNama?: string;
    ThAng?: string;
    Alamat?: string;
    Op?: string;
    Lu?: string;
    Pc?: string;
    Dlt?: boolean;
    Npwp?: string;
    IsBlud?: number;
    NoUrut?: number;
}

export abstract class OPDRow {
    static readonly idProperty = 'UnitId';
    static readonly nameProperty = 'UnitNama';
    static readonly localTextPrefix = 'MasterData.OPD';
    static readonly lookupKey = 'MasterData.OPD';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<OPDRow>('MasterData.OPD') }
    static async getLookupAsync() { return getLookupAsync<OPDRow>('MasterData.OPD') }

    static readonly deletePermission = 'Opd:Delete';
    static readonly insertPermission = 'Opd:Insert';
    static readonly readPermission = 'Opd:View';
    static readonly updatePermission = 'Opd:Update';

    static readonly Fields = fieldsProxy<OPDRow>();
}