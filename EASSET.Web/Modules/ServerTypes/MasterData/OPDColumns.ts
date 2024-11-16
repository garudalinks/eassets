import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { OPDRow } from "./OPDRow";

export interface OPDColumns {
    UnitNama: Column<OPDRow>;
    UnitKode: Column<OPDRow>;
    Alamat: Column<OPDRow>;
}

export class OPDColumns extends ColumnsBase<OPDRow> {
    static readonly columnsKey = 'MasterData.OPD';
    static readonly Fields = fieldsProxy<OPDColumns>();
}