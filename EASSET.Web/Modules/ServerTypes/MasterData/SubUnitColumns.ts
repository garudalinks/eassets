import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SubUnitRow } from "./SubUnitRow";

export interface SubUnitColumns {
    SubUnitNama: Column<SubUnitRow>;
    SubUnitKode: Column<SubUnitRow>;
    UnitNama: Column<SubUnitRow>;
    Alamat: Column<SubUnitRow>;
    Npwp: Column<SubUnitRow>;
}

export class SubUnitColumns extends ColumnsBase<SubUnitRow> {
    static readonly columnsKey = 'MasterData.SubUnit';
    static readonly Fields = fieldsProxy<SubUnitColumns>();
}