import { SubKegiatanForm, SubKegiatanRow, SubKegiatanService } from '@/ServerTypes/MasterData';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('EASSET.MasterData.SubKegiatanDialog')
export class SubKegiatanDialog extends EntityDialog<SubKegiatanRow, any> {
    protected getFormKey() { return SubKegiatanForm.formKey; }
    protected getRowDefinition() { return SubKegiatanRow; }
    protected getService() { return SubKegiatanService.baseUrl; }

    protected form = new SubKegiatanForm(this.idPrefix);
}