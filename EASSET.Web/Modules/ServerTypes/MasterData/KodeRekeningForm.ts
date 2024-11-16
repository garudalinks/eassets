import { PrefixedContext, initFormType } from "@serenity-is/corelib";
import { StringEditor, IntegerEditor } from "serenity.corelib";

export interface KodeRekeningForm {
    Akun108Id: StringEditor;
    AkunView: StringEditor;
    Kelompok108Id: StringEditor;
    KelompokView: StringEditor;
    Jenis108Id: StringEditor;
    JenisView: StringEditor;
    Objek108Id: StringEditor;
    ObjekView: StringEditor;
    Ro108Id: StringEditor;
    RoView: StringEditor;
    SubRo108Id: StringEditor;
    SubRoView: StringEditor;
    SubSubRo108Id: StringEditor;
    SubSubRoView: StringEditor;
    KodeRekening108: StringEditor;
    ThAng: StringEditor;
    IsEnabled: IntegerEditor;
}

export class KodeRekeningForm extends PrefixedContext {
    static readonly formKey = 'MasterData.KodeRekening';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!KodeRekeningForm.init)  {
            KodeRekeningForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(KodeRekeningForm, [
                'Akun108Id', w0,
                'AkunView', w0,
                'Kelompok108Id', w0,
                'KelompokView', w0,
                'Jenis108Id', w0,
                'JenisView', w0,
                'Objek108Id', w0,
                'ObjekView', w0,
                'Ro108Id', w0,
                'RoView', w0,
                'SubRo108Id', w0,
                'SubRoView', w0,
                'SubSubRo108Id', w0,
                'SubSubRoView', w0,
                'KodeRekening108', w0,
                'ThAng', w0,
                'IsEnabled', w1
            ]);
        }
    }
}