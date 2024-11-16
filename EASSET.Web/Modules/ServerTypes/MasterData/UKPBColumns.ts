import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { UKPBRow } from "./UKPBRow";

export interface UKPBColumns {
    UkpbNama: Column<UKPBRow>;
    UkpbKode: Column<UKPBRow>;
    UpbNama: Column<UKPBRow>;
    UnitNama: Column<UKPBRow>;
    SubUnitNama: Column<UKPBRow>;
    UkpbAlamat: Column<UKPBRow>;
}

export class UKPBColumns extends ColumnsBase<UKPBRow> {
    static readonly columnsKey = 'MasterData.UKPB';
    static readonly Fields = fieldsProxy<UKPBColumns>();
}