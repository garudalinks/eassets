import { SubKegiatanColumns, SubKegiatanRow, SubKegiatanService } from '@/ServerTypes/MasterData';
import { GroupItemMetadataProvider, RowSelectionModel, GridOptions } from "@serenity-is/sleekgrid";
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SubKegiatanDialog } from './SubKegiatanDialog';

@Decorators.registerClass('EASSET.MasterData.SubKegiatanGrid')
export class SubKegiatanGrid extends EntityGrid<SubKegiatanRow> {
    protected getColumnsKey() { return SubKegiatanColumns.columnsKey; }
    protected getDialogType() { return SubKegiatanDialog; }
    protected getRowDefinition() { return SubKegiatanRow; }
    protected getService() { return SubKegiatanService.baseUrl; }

    protected createSlickGrid() {
        var grid = super.createSlickGrid();

        // need to register this plugin for grouping or you'll have errors
        grid.registerPlugin(new GroupItemMetadataProvider());
        grid.setSelectionModel(new RowSelectionModel());

        this.view.setGrouping(
            [
                {
                    formatter: x => x.value,
                    getter: 'BidangView',
                    aggregators: [],
                    aggregateCollapsed: true,  // Menampilkan jumlah total group yang tersembunyi
                    lazyTotalsCalculation: true  // Hitung total secara dinamis
                },
                {
                    formatter: x => x.value,
                    getter: 'UrusanView',
                    aggregators: [],
                    aggregateCollapsed: true,  // Menampilkan jumlah total group yang tersembunyi
                    lazyTotalsCalculation: true  // Hitung total secara dinamis
                },
                {
                    formatter: x => x.value,
                    getter: 'ProgView',
                    aggregators: [],
                    aggregateCollapsed: true,  // Menampilkan jumlah total group yang tersembunyi
                    lazyTotalsCalculation: true  // Hitung total secara dinamis
                },
                {
                    formatter: x => x.value,
                    getter: 'KegView',
                    aggregators: [],
                    aggregateCollapsed: true,  // Menampilkan jumlah total group yang tersembunyi
                    lazyTotalsCalculation: true  // Hitung total secara dinamis
                }
            ])
        return grid;
    }

    protected getSlickOptions(): GridOptions {
        var opt = super.getSlickOptions();
        opt.enableTextSelectionOnCells = true;
        opt.selectedCellCssClass = "slick-row-selected";
        opt.enableCellNavigation = true;
        opt.rowHeight = 50;
        return opt;
    }
    //protected getItemCssClass(item: SubKegiatanRow, index: number): string {
    //    if (item.SubKegView) {
    //        return "row-subkegiatan";
    //    }

    //    return ""; // Tidak ada warna khusus
    //}
}