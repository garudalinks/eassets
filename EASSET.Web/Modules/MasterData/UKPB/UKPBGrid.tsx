import { UKPBColumns, UKPBRow, UKPBService } from '@/ServerTypes/MasterData';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { UKPBDialog } from './UKPBDialog';
import { HeaderFiltersMixin } from "@serenity-is/pro.extensions";

@Decorators.registerClass('EASSET.MasterData.UKPBGrid')
export class UKPBGrid extends EntityGrid<UKPBRow> {
    protected getColumnsKey() { return UKPBColumns.columnsKey; }
    protected getDialogType() { return UKPBDialog; }
    protected getRowDefinition() { return UKPBRow; }
    protected getService() { return UKPBService.baseUrl; }

    //constructor(container: JQuery) {
    //    super(container);

    //    new HeaderFiltersMixin({
    //        grid: this
    //    });
    //}
}