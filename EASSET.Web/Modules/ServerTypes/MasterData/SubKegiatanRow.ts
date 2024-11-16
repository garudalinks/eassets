import { fieldsProxy } from "@serenity-is/corelib";

export interface SubKegiatanRow {
    Id?: number;
    BidangView?: string;
    UrusanView?: string;
    ProgView?: string;
    KegView?: string;
    SubKegView?: string;
    SubKeg50Id?: string;
    SubKeg50Kode?: string;
}

export abstract class SubKegiatanRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'SubKegView';
    static readonly localTextPrefix = 'MasterData.SubKegiatan';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SubKegiatanRow>();
}