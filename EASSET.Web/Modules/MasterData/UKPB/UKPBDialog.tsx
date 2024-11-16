import { UKPBForm, UKPBRow, UKPBService } from '@/ServerTypes/MasterData';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('EASSET.MasterData.UKPBDialog')
export class UKPBDialog extends EntityDialog<UKPBRow, any> {
    protected getFormKey() { return UKPBForm.formKey; }
    protected getRowDefinition() { return UKPBRow; }
    protected getService() { return UKPBService.baseUrl; }

    protected form = new UKPBForm(this.idPrefix);
}