import { SubUnitColumns, SubUnitRow, SubUnitService } from '@/ServerTypes/MasterData';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SubUnitDialog } from './SubUnitDialog';

@Decorators.registerClass('EASSET.MasterData.SubUnitGrid')
export class SubUnitGrid extends EntityGrid<SubUnitRow> {
    protected getColumnsKey() { return SubUnitColumns.columnsKey; }
    protected getDialogType() { return SubUnitDialog; }
    protected getRowDefinition() { return SubUnitRow; }
    protected getService() { return SubUnitService.baseUrl; }
}