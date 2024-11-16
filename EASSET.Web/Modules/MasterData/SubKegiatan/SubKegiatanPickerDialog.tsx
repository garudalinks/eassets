import { BaseDialog, Decorators, EntityDialog, ToolButton, Toolbar, ToolbarButton } from '@serenity-is/corelib';
import { SubKegiatanGrid } from '@/MasterData/SubKegiatan/SubKegiatanGrid';
import * as Slick from "@serenity-is/sleekgrid";
import { SubKegiatanRow, SubKegiatanService } from '../../ServerTypes/MasterData';
import { RKBMDForm, RKBMDService } from '@/ServerTypes/Perencanaan';
import { RKBMDDialog } from "@/Perencanaan/RKBMD/RKBMDDialog";
import { SlickGrid } from 'slickgrid';

@Decorators.registerClass('SubKegiatanPickerDialog.MasterData.SubKegiatan')
export class SubKegiatanPickerDialog extends BaseDialog<any> {
    protected getFormKey() { return RKBMDForm.formKey; }
    protected getService() { return SubKegiatanService.baseUrl; }
    protected getIdProperty() { return SubKegiatanRow.idProperty; }
    protected getLocalTextPrefix() { return SubKegiatanRow.localTextPrefix; }

    private SubKegiatanGrid: SubKegiatanGrid;
    protected form = new RKBMDForm(this.idPrefix);
    protected SubKegiatan: string = "";
    constructor() {
        super()
        this.SubKegiatanGrid = new SubKegiatanGrid(this.byId('SubKegGrid'));
        this.SubKegiatanGrid.slickGrid.onSelectedRowsChanged.subscribe((e, args) => {
            let selectedRow = this.SubKegiatanGrid.slickGrid.getSelectedRows();
            selectedRow.forEach(rowIndex => {
                let rowData = this.SubKegiatanGrid.slickGrid.getDataItem(rowIndex);
                this.SubKegiatan = rowData;
            });
        });
    }
    protected getTemplate() {
        return `
            <div id='~_SubKegGrid'></div>
            <div class="buttons mt-3 d-flex justify-content-end">
                <button class="btn btn-primary ok-button me-1">OK</button>
                <button class="btn btn-secondary cancel-button">Cancel</button>
            </div>`;
    }

    public getValueKodeRekening(subKegiatan) {
        return subKegiatan;
    }

    protected onDialogOpen() {
        super.onDialogOpen();
        // Handle event klik pada tombol OK
        this.element.findFirst('.ok-button').click(() => this.dialogOkClick());
        this.element.findFirst('.cancel-button').click(() => this.dialogClose());
    }

    private dialogOkClick() {
        let selectedItems = this.SubKegiatan;  // Ambil data yang dipilih dari grid
        
        if (selectedItems.length === 0) {
            Q.notifyWarning("Pilih setidaknya satu item.");
            return;
        }
        console.log(selectedItems);
        //// Memanggil callback atau event untuk mengembalikan data yang dipilih
        this.okClick && this.okClick(selectedItems);
        // Tutup dialog setelah OK diklik
        this.dialogClose();
    }

    public okClick: (selectedItems: any) => void;
}
