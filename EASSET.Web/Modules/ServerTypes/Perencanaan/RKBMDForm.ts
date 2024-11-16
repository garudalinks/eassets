import { PrefixedContext, initFormType } from "@serenity-is/corelib";
import { StringEditor, DecimalEditor, TextAreaEditor } from "serenity.corelib";

export interface RKBMDForm {
    KodeRekening: StringEditor;
    NamaRekening: StringEditor;
    JmlUsulan: DecimalEditor;
    JmlKebMax: DecimalEditor;
    JmlExisting: DecimalEditor;
    SubKegNama: StringEditor;
    Keterangan: TextAreaEditor;
    SubSubRo108Id: StringEditor;
    SubKegId: StringEditor;
    SubKegKode: StringEditor;
}

export class RKBMDForm extends PrefixedContext {
    static readonly formKey = 'Perencanaan.RKBMD';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!RKBMDForm.init)  {
            RKBMDForm.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;
            var w2 = TextAreaEditor;

            initFormType(RKBMDForm, [
                'KodeRekening', w0,
                'NamaRekening', w0,
                'JmlUsulan', w1,
                'JmlKebMax', w1,
                'JmlExisting', w1,
                'SubKegNama', w0,
                'Keterangan', w2,
                'SubSubRo108Id', w0,
                'SubKegId', w0,
                'SubKegKode', w0
            ]);
        }
    }
}