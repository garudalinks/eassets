import { RuangColumns, RuangRow, RuangService } from '@/ServerTypes/MasterData';
import { Decorators, EntityGrid, Aggregators, formatNumber } from '@serenity-is/corelib';
import { RuangDialog } from './RuangDialog';
import { GroupItemMetadataProvider, RowSelectionModel, GridOptions } from "@serenity-is/sleekgrid";


@Decorators.registerClass('EASSET.MasterData.RuangGrid')
export class RuangGrid extends EntityGrid<RuangRow> {
    protected getColumnsKey() { return RuangColumns.columnsKey; }
    protected getDialogType() { return RuangDialog; }
    protected getRowDefinition() { return RuangRow; }
    protected getService() { return RuangService.baseUrl; }


    //constructor(container) {
    //    super(container)
    //    // get value on selected row
    //    this.slickGrid.onClick.subscribe((e, args) => {
    //        let item = this.itemAt(args.row);
    //        let ruangNama = item.RuangNama;

    //        console.log('You click at ' + ruangNama);
    //    })
    //}

    protected createSlickGrid() {
        var grid = super.createSlickGrid();

        // need to register this plugin for grouping or you'll have errors
        grid.registerPlugin(new GroupItemMetadataProvider());
        grid.setSelectionModel(new RowSelectionModel())
        //this.view.setSummaryOptions({
        //    aggregators: [
        //        new Aggregators.Avg('UnitPrice'),
        //        new Aggregators.Sum('UnitsInStock'),
        //        new Aggregators.Max('UnitsOnOrder'),
        //        new Aggregators.Avg('ReorderLevel')
        //    ]
        //});
        this.view.setGrouping(
            [{
                formatter: x => x.value ? 'OPD: ' + x.value + ' (' + x.count + ' items)' : 'OPD: Lainnnya',
                getter: 'UnitNama',
                aggregators: [],
                aggregateCollapsed: true,  // Menampilkan jumlah total group yang tersembunyi
                lazyTotalsCalculation: true  // Hitung total secara dinamis
            }])
        return grid;
    }

        protected getSlickOptions(): GridOptions {
            var opt = super.getSlickOptions();
            opt.enableTextSelectionOnCells = true;
            opt.selectedCellCssClass = "slick-row-selected";
            opt.enableCellNavigation = true;
            return opt;
        }
    }


    

    //protected getColumns() {
    //    var columns = new RuangColumns(super.getColumns());

    //    columns.RuangKode && (columns.RuangKode.groupTotalsFormatter = (totals, col) =>
    //        (totals.max ? ('max: ' + (totals.max[col.field] ?? '')) : ''));

    //    //columns.ReorderLevel && (columns.ReorderLevel.groupTotalsFormatter = (totals, col) =>
    //    //    (totals.avg ? ('avg: ' + (formatNumber(totals.avg[col.field], '0.') ?? '')) : ''));

    //    return columns.valueOf();
    //}

    //protected getSlickOptions() {
    //    var opt = super.getSlickOptions();
    //    opt.showFooterRow = true;
    //    return opt;
    //}

    //protected usePager() {
    //    return false;
    //}

    //protected getButtons() {
    //    return [{
    //        title: 'Group By Category',
    //        separator: true,
    //        cssClass: 'expand-all-button',
    //        onClick: () => this.view.setGrouping(
    //            [{
    //                getter: 'UnitNama'
    //            }])
    //    },
    //    {
    //        title: 'Group By Category and Supplier',
    //        separator: true,
    //        cssClass: 'expand-all-button',
    //        onClick: () => this.view.setGrouping(
    //            [{
    //                formatter: x => 'OPD: ' + x.value + ' (' + x.count + ' items)',
    //                getter: 'UnitNama',
    //            }, {
    //                formatter: x => 'Sub Unit: ' + x.value + ' (' + x.count + ' items)',
    //                getter: 'SubUnitNama'
    //            }])
    //    }, {
    //        title: 'No Grouping',
    //        separator: true,
    //        cssClass: 'collapse-all-button',
    //        onClick: () => this.view.setGrouping([])
    //    }];
//}
    
/*}*/
