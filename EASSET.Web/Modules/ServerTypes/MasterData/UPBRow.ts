import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface UPBRow {
    Upbid?: string;
    UnitId?: string;
    SubUnitId?: string;
    UpbKode?: string;
    UpbNama?: string;
    ThAng?: string;
    Op?: string;
    Lu?: string;
    Pc?: string;
    Dlt?: number;
    UnitNama?: string;
    SubUnitNama?: string;
}

export abstract class UPBRow {
    static readonly idProperty = 'Upbid';
    static readonly nameProperty = 'UpbNama';
    static readonly localTextPrefix = 'MasterData.UPB';
    static readonly lookupKey = 'MasterData.UPB';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<UPBRow>('MasterData.UPB') }
    static async getLookupAsync() { return getLookupAsync<UPBRow>('MasterData.UPB') }

    static readonly deletePermission = 'Upb:Delete';
    static readonly insertPermission = 'Upb:Insert';
    static readonly readPermission = 'Upb:View';
    static readonly updatePermission = 'Upb:Update';

    static readonly Fields = fieldsProxy<UPBRow>();
}