import { KodeRekeningColumns, KodeRekeningRow, KodeRekeningService } from '@/ServerTypes/MasterData';
import { GroupItemMetadataProvider, RowSelectionModel, GridOptions } from "@serenity-is/sleekgrid";
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { KodeRekeningDialog } from './KodeRekeningDialog';

@Decorators.registerClass('EASSET.MasterData.KodeRekeningGrid')
export class KodeRekeningGrid extends EntityGrid<KodeRekeningRow> {
    protected getColumnsKey() { return KodeRekeningColumns.columnsKey; }
    protected getDialogType() { return KodeRekeningDialog; }
    protected getRowDefinition() { return KodeRekeningRow; }
    protected getService() { return KodeRekeningService.baseUrl; }

    protected createSlickGrid() {
        var grid = super.createSlickGrid();

        // need to register this plugin for grouping or you'll have errors
        grid.registerPlugin(new GroupItemMetadataProvider());
        grid.setSelectionModel(new RowSelectionModel());

        this.view.setGrouping(
            [
                {
                    formatter: x => x.value,
                    getter: 'KelompokView',
                    aggregators: [],
                    aggregateCollapsed: true,  // Menampilkan jumlah total group yang tersembunyi
                    lazyTotalsCalculation: true  // Hitung total secara dinamis
                },
                {
                    formatter: x => x.value,
                    getter: 'JenisView',
                    aggregators: [],
                    aggregateCollapsed: true,  // Menampilkan jumlah total group yang tersembunyi
                    lazyTotalsCalculation: true  // Hitung total secara dinamis
                },
                {
                    formatter: x => x.value,
                    getter: 'ObjekView',
                    aggregators: [],
                    aggregateCollapsed: true,  // Menampilkan jumlah total group yang tersembunyi
                    lazyTotalsCalculation: true  // Hitung total secara dinamis
                },
                {
                    formatter: x => x.value,
                    getter: 'RoView',
                    aggregators: [],
                    aggregateCollapsed: true,  // Menampilkan jumlah total group yang tersembunyi
                    lazyTotalsCalculation: true  // Hitung total secara dinamis
                },
                {
                    formatter: x => x.value,
                    getter: 'SubRoView',
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
}