import { KodeRekeningForm, KodeRekeningRow,KodeRekeningService } from '@/ServerTypes/MasterData';
import { BaseDialog, Decorators, EntityDialog, ToolButton, Toolbar, ToolbarButton } from '@serenity-is/corelib';
import { KodeRekeningGrid } from '@/MasterData/KodeRekening/KodeRekeningGrid';
import * as Slick from "@serenity-is/sleekgrid";
import { RKBMDForm, RKBMDService } from '@/ServerTypes/Perencanaan';
import { RKBMDDialog } from "@/Perencanaan/RKBMD/RKBMDDialog";

@Decorators.registerClass('KodeRekeningPickerDialog.MasterData.KodeRekening')
export class KodeRekeningPickerDialog extends BaseDialog<any> {
    //protected getFormKey() { return KodeRekeningForm.formKey; }
    protected getFormKey() { return RKBMDForm.formKey; }
    protected getService() { return KodeRekeningService.baseUrl; }
    protected getIdProperty() { return KodeRekeningRow.idProperty; }
    protected getLocalTextPrefix() { return KodeRekeningRow.localTextPrefix; }

    private kodeRekeningGrid: KodeRekeningGrid;
    protected form = new RKBMDForm(this.idPrefix);
    protected kodeRekening: string = "";
    constructor() {
        super()
        this.kodeRekeningGrid = new KodeRekeningGrid(this.byId('ProductGrid'));
        this.kodeRekeningGrid.slickGrid.onSelectedRowsChanged.subscribe((e, args) => {
            let selectedRow = this.kodeRekeningGrid.slickGrid.getSelectedRows();
            selectedRow.forEach(rowIndex => {
                let rowData = this.kodeRekeningGrid.slickGrid.getDataItem(rowIndex);
                this.kodeRekening = rowData;
            });
        });
    }
    protected getTemplate() {
        return `
            <div id='~_ProductGrid'></div>
            <div class="buttons mt-3 d-flex justify-content-end">
                <button class="btn btn-primary ok-button me-1">OK</button>
                <button class="btn btn-secondary cancel-button">Cancel</button>
            </div>`;
    }

    public getValueKodeRekening(kodeRekening) {
        return kodeRekening;
    }

    protected onDialogOpen() {
        super.onDialogOpen();
        // Handle event klik pada tombol OK
        this.element.findFirst('.ok-button').click(() => this.dialogOkClick());
        this.element.findFirst('.cancel-button').click(() => this.dialogClose());
    }

    private dialogOkClick() {
        let selectedItems = this.kodeRekening;  // Ambil data yang dipilih dari grid

        if (selectedItems.length === 0) {
            Q.notifyWarning("Pilih setidaknya satu item.");
            return;
        }

        //// Memanggil callback atau event untuk mengembalikan data yang dipilih
        this.okClick && this.okClick(selectedItems);
        // Tutup dialog setelah OK diklik
        this.dialogClose();
    }

    public okClick: (selectedItems: any) => void;
}