import { SubUnitForm, SubUnitRow, SubUnitService } from '@/ServerTypes/MasterData';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('EASSET.MasterData.SubUnitDialog')
export class SubUnitDialog extends EntityDialog<SubUnitRow, any> {
    protected getFormKey() { return SubUnitForm.formKey; }
    protected getRowDefinition() { return SubUnitRow; }
    protected getService() { return SubUnitService.baseUrl; }

    protected form = new SubUnitForm(this.idPrefix);
}