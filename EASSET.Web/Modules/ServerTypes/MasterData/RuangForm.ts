import { PrefixedContext, initFormType } from "@serenity-is/corelib";
import { StringEditor, ServiceLookupEditor } from "serenity.corelib";

export interface RuangForm {
    RuangKode: StringEditor;
    RuangNama: StringEditor;
    UnitId: ServiceLookupEditor;
    SubUnitId: ServiceLookupEditor;
    ThAng: StringEditor;
}

export class RuangForm extends PrefixedContext {
    static readonly formKey = 'MasterData.Ruang';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!RuangForm.init)  {
            RuangForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;

            initFormType(RuangForm, [
                'RuangKode', w0,
                'RuangNama', w0,
                'UnitId', w1,
                'SubUnitId', w1,
                'ThAng', w0
            ]);
        }
    }
}