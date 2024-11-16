import { PrefixedContext, initFormType } from "@serenity-is/corelib";
import { ServiceLookupEditor, StringEditor, TextAreaEditor } from "serenity.corelib";

export interface UKPBForm {
    UnitId: ServiceLookupEditor;
    SubUnitId: ServiceLookupEditor;
    Upbid: ServiceLookupEditor;
    UkpbKode: StringEditor;
    UkpbNama: StringEditor;
    UkpbAlamat: TextAreaEditor;
}

export class UKPBForm extends PrefixedContext {
    static readonly formKey = 'MasterData.UKPB';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!UKPBForm.init)  {
            UKPBForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;

            initFormType(UKPBForm, [
                'UnitId', w0,
                'SubUnitId', w0,
                'Upbid', w0,
                'UkpbKode', w1,
                'UkpbNama', w1,
                'UkpbAlamat', w2
            ]);
        }
    }
}