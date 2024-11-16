import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SubKegiatanRow } from "./SubKegiatanRow";

export interface SubKegiatanColumns {
    KegView: Column<SubKegiatanRow>;
    SubKegView: Column<SubKegiatanRow>;
}

export class SubKegiatanColumns extends ColumnsBase<SubKegiatanRow> {
    static readonly columnsKey = 'MasterData.SubKegiatan';
    static readonly Fields = fieldsProxy<SubKegiatanColumns>();
}