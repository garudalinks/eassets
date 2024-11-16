import { KodeRekeningForm, KodeRekeningRow, KodeRekeningService } from '@/ServerTypes/MasterData';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('EASSET.MasterData.KodeRekeningDialog')
export class KodeRekeningDialog extends EntityDialog<KodeRekeningRow, any> {
    protected getFormKey() { return KodeRekeningForm.formKey; }
    protected getRowDefinition() { return KodeRekeningRow; }
    protected getService() { return KodeRekeningService.baseUrl; }

    protected form = new KodeRekeningForm(this.idPrefix);
}