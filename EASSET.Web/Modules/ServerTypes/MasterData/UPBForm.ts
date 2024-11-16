import { PrefixedContext, initFormType } from "@serenity-is/corelib";
import { ServiceLookupEditor, StringEditor } from "serenity.corelib";

export interface UPBForm {
    UnitId: ServiceLookupEditor;
    SubUnitId: ServiceLookupEditor;
    UpbKode: StringEditor;
    UpbNama: StringEditor;
}

export class UPBForm extends PrefixedContext {
    static readonly formKey = 'MasterData.UPB';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!UPBForm.init)  {
            UPBForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;

            initFormType(UPBForm, [
                'UnitId', w0,
                'SubUnitId', w0,
                'UpbKode', w1,
                'UpbNama', w1
            ]);
        }
    }
}