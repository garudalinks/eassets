import { fieldsProxy } from "@serenity-is/corelib";

export interface RuangRow {
    RuangId?: string;
    UnitId?: string;
    SubUnitId?: string;
    RuangKode?: string;
    RuangNama?: string;
    ThAng?: string;
    Op?: string;
    Lu?: string;
    Pc?: string;
    Dlt?: number;
    UnitNama?: string;
    SubUnitNama?: string;
}

export abstract class RuangRow {
    static readonly idProperty = 'RuangId';
    static readonly nameProperty = 'RuangNama';
    static readonly localTextPrefix = 'MasterData.Ruang';
    static readonly deletePermission = 'Ruang:Delete';
    static readonly insertPermission = 'Ruang:Insert';
    static readonly readPermission = 'Ruang:View';
    static readonly updatePermission = 'Ruang:Update';

    static readonly Fields = fieldsProxy<RuangRow>();
}