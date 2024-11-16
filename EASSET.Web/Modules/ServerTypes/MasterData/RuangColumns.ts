import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { RuangRow } from "./RuangRow";

export interface RuangColumns {
    RuangNama: Column<RuangRow>;
    RuangKode: Column<RuangRow>;
    UnitNama: Column<RuangRow>;
    SubUnitNama: Column<RuangRow>;
}

export class RuangColumns extends ColumnsBase<RuangRow> {
    static readonly columnsKey = 'MasterData.Ruang';
    static readonly Fields = fieldsProxy<RuangColumns>();
}