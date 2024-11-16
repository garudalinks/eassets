import { RKBMDForm} from '@/ServerTypes/Perencanaan/RKBMDForm';
import { RKBMDRow } from '@/ServerTypes/Perencanaan/RKBMDRow';
import { RKBMDService } from '@/ServerTypes/Perencanaan/RKBMDService';
import { Decorators, EntityDialog, BaseDialog } from '@serenity-is/corelib';
import { RuangDialog } from '../../MasterData/Ruang/RuangDialog';
import * as bootstrap from "bootstrap";
import { Grid, GridApi, ColDef, LicenseManager } from "ag-grid-enterprise";
import { KodeRekeningPickerDialog } from "@/MasterData/KodeRekening/KodeRekeningPickerDialog";
import { SubKegiatanPickerDialog } from "@/MasterData/SubKegiatan/SubKegiatanPickerDialog";
import { KodeRekeningGrid } from '@/MasterData/KodeRekening/KodeRekeningGrid';
import { SubKegiatanGrid } from '../../MasterData/SubKegiatan/SubKegiatanGrid';

@Decorators.registerClass('EASSET.Perencanaan.RKBMDDialog')
export class RKBMDDialog extends EntityDialog<RKBMDRow, any> {
    protected getFormKey() { return RKBMDForm.formKey; }
    protected getRowDefinition() { return RKBMDRow; }
    protected getService() { return RKBMDService.baseUrl; }

    public form = new RKBMDForm(this.idPrefix);
    private kodeRekeningGrid: KodeRekeningGrid;
    constructor() {
        super()
        this.getValueKodeRekening();
    }

    protected getValueKodeRekening() {
        this.form.KodeRekening.element.click(e => {
            var dialog = new KodeRekeningPickerDialog();
            dialog.dialogOpen();

            //set value to form
            dialog.okClick = (selectedProducts) => {
                console.log(selectedProducts, "okKlick");
                this.form.KodeRekening.value = selectedProducts.SubSubRoView;
                this.form.SubSubRo108Id.value = selectedProducts.SubSubRo108Id;
            };
        });
        this.form.SubKegNama.element.click(e => {
            var dialog = new SubKegiatanPickerDialog();
            dialog.dialogOpen();

            dialog.okClick = (selectedProducts) => {
                this.form.SubKegNama.value = selectedProducts.SubKegView;
                this.form.SubKegId.value = selectedProducts.SubKeg50Id;
                this.form.SubKegKode.value = selectedProducts.SubKeg50Kode;
            };
        })
    }
}


