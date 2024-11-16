import { PrefixedContext, initFormType } from "@serenity-is/corelib";
import { ServiceLookupEditor, StringEditor, TextAreaEditor } from "serenity.corelib";

export interface SubUnitForm {
    UnitId: ServiceLookupEditor;
    SubUnitKode: StringEditor;
    SubUnitNama: StringEditor;
    Npwp: StringEditor;
    Alamat: TextAreaEditor;
}

export class SubUnitForm extends PrefixedContext {
    static readonly formKey = 'MasterData.SubUnit';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SubUnitForm.init)  {
            SubUnitForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;

            initFormType(SubUnitForm, [
                'UnitId', w0,
                'SubUnitKode', w1,
                'SubUnitNama', w1,
                'Npwp', w1,
                'Alamat', w2
            ]);
        }
    }
}