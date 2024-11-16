import { UPBForm, UPBRow, UPBService } from '@/ServerTypes/MasterData';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('EASSET.MasterData.UPBDialog')
export class UPBDialog extends EntityDialog<UPBRow, any> {
    protected getFormKey() { return UPBForm.formKey; }
    protected getRowDefinition() { return UPBRow; }
    protected getService() { return UPBService.baseUrl; }

    protected form = new UPBForm(this.idPrefix);
}