import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { KodeRekeningRow } from "./KodeRekeningRow";

export interface KodeRekeningColumns {
    SubSubRoView: Column<KodeRekeningRow>;
}

export class KodeRekeningColumns extends ColumnsBase<KodeRekeningRow> {
    static readonly columnsKey = 'MasterData.KodeRekening';
    static readonly Fields = fieldsProxy<KodeRekeningColumns>();
}