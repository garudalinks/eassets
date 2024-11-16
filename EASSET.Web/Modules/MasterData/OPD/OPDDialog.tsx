import { OPDForm, OPDRow, OPDService } from '@/ServerTypes/MasterData';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('EASSET.MasterData.OPDDialog')
export class OPDDialog extends EntityDialog<OPDRow, any> {
    protected getFormKey() { return OPDForm.formKey; }
    protected getRowDefinition() { return OPDRow; }
    protected getService() { return OPDService.baseUrl; }

    protected form = new OPDForm(this.idPrefix);
}