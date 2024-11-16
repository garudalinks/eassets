import { OPDColumns, OPDRow, OPDService } from '@/ServerTypes/MasterData';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { OPDDialog } from './OPDDialog';

@Decorators.registerClass('EASSET.MasterData.OPDGrid')
export class OPDGrid extends EntityGrid<OPDRow> {
    protected getColumnsKey() { return OPDColumns.columnsKey; }
    protected getDialogType() { return OPDDialog; }
    protected getRowDefinition() { return OPDRow; }
    protected getService() { return OPDService.baseUrl; }
}