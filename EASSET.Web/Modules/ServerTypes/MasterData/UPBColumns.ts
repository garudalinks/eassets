import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { UPBRow } from "./UPBRow";

export interface UPBColumns {
    UpbNama: Column<UPBRow>;
    UpbKode: Column<UPBRow>;
    UnitNama: Column<UPBRow>;
    SubUnitNama: Column<UPBRow>;
}

export class UPBColumns extends ColumnsBase<UPBRow> {
    static readonly columnsKey = 'MasterData.UPB';
    static readonly Fields = fieldsProxy<UPBColumns>();
}