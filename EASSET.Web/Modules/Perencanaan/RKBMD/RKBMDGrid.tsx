import { RKBMDColumns, RKBMDRow, RKBMDService } from '@/ServerTypes/Perencanaan';
import { Decorators, EntityGrid} from '@serenity-is/corelib';
import { RKBMDDialog } from './RKBMDDialog';

@Decorators.registerClass('EASSET.Perencanaan.RKBMDGrid')
export class RKBMDGrid extends EntityGrid<RKBMDRow> {
    protected getColumnsKey() { return RKBMDColumns.columnsKey; }
    protected getDialogType() { return RKBMDDialog; }
    protected getRowDefinition() { return RKBMDRow; }
    protected getService() { return RKBMDService.baseUrl; }


    protected getColumns() {
        let columns = super.getColumns();

        columns.forEach(column => {
            // Menghitung panjang title kolom dan menetapkan lebar yang sesuai
            let titleLength = column.name.length;

            // Hitung lebar berdasarkan panjang title, misalnya 10 pixel per karakter
            column.width = Math.max(titleLength * 10, 80); // Minimum 80px untuk lebar kolom
        });

        return columns;
    }


}