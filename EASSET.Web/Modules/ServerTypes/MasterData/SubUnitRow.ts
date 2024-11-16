import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface SubUnitRow {
    SubUnitId?: string;
    UnitId?: string;
    SubUnitKode?: string;
    SubUnitNama?: string;
    ThAng?: string;
    Op?: string;
    Lu?: string;
    Pc?: string;
    Dlt?: boolean;
    Alamat?: string;
    Npwp?: string;
    UnitNama?: string;
}

export abstract class SubUnitRow {
    static readonly idProperty = 'SubUnitId';
    static readonly nameProperty = 'SubUnitNama';
    static readonly localTextPrefix = 'MasterData.SubUnit';
    static readonly lookupKey = 'MasterData.SubUnit';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<SubUnitRow>('MasterData.SubUnit') }
    static async getLookupAsync() { return getLookupAsync<SubUnitRow>('MasterData.SubUnit') }

    static readonly deletePermission = 'Sub Unit:Delete';
    static readonly insertPermission = 'Sub Unit:Insert';
    static readonly readPermission = 'Sub Unit:View';
    static readonly updatePermission = 'Sub Unit:Update';

    static readonly Fields = fieldsProxy<SubUnitRow>();
}