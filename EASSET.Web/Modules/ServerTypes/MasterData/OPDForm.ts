import { PrefixedContext, initFormType } from "@serenity-is/corelib";
import { StringEditor, IntegerEditor, TextAreaEditor } from "serenity.corelib";

export interface OPDForm {
    UnitKode: StringEditor;
    UnitNama: StringEditor;
    Npwp: StringEditor;
    IsBlud: IntegerEditor;
    NoUrut: IntegerEditor;
    Alamat: TextAreaEditor;
}

export class OPDForm extends PrefixedContext {
    static readonly formKey = 'MasterData.OPD';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!OPDForm.init)  {
            OPDForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = TextAreaEditor;

            initFormType(OPDForm, [
                'UnitKode', w0,
                'UnitNama', w0,
                'Npwp', w0,
                'IsBlud', w1,
                'NoUrut', w1,
                'Alamat', w2
            ]);
        }
    }
}