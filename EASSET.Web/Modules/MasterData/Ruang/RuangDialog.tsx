import { RuangForm, RuangRow, RuangService } from '@/ServerTypes/MasterData';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('EASSET.MasterData.RuangDialog')
export class RuangDialog extends EntityDialog<RuangRow, any> {
    //protected getFormKey() { return RuangForm.formKey; }
    protected getRowDefinition() { return RuangRow; }
    protected getService() { return RuangService.baseUrl; }

    //protected form = new RuangForm(this.idPrefix);


}