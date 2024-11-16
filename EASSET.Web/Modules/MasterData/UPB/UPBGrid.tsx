import { UPBColumns, UPBRow, UPBService } from '@/ServerTypes/MasterData';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { UPBDialog } from './UPBDialog';

@Decorators.registerClass('EASSET.MasterData.UPBGrid')
export class UPBGrid extends EntityGrid<UPBRow> {
    protected getColumnsKey() { return UPBColumns.columnsKey; }
    protected getDialogType() { return UPBDialog; }
    protected getRowDefinition() { return UPBRow; }
    protected getService() { return UPBService.baseUrl; }

    //constructor(container: JQuery) {
    //    super(container);

    //    new Serenity.HeaderFiltersMixin({
    //        grid: this
    //    });
    //}
}
