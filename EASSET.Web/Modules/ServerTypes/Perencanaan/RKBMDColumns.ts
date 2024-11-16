import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { RKBMDRow } from "./RKBMDRow";

export interface RKBMDColumns {
    NoUrut: Column<RKBMDRow>;
    SubKegNama: Column<RKBMDRow>;
    KodeRekening: Column<RKBMDRow>;
    NamaRekening: Column<RKBMDRow>;
    JmlKebMax: Column<RKBMDRow>;
    JmlExisting: Column<RKBMDRow>;
    JmlUsulan: Column<RKBMDRow>;
    Keterangan: Column<RKBMDRow>;
}

export class RKBMDColumns extends ColumnsBase<RKBMDRow> {
    static readonly columnsKey = 'Perencanaan.RKBMD';
    static readonly Fields = fieldsProxy<RKBMDColumns>();
}