import { PrefixedContext, initFormType } from "@serenity-is/corelib";
import { StringEditor } from "serenity.corelib";

export interface SubKegiatanForm {
    BidangView: StringEditor;
    UrusanView: StringEditor;
    ProgView: StringEditor;
    KegView: StringEditor;
    SubKegView: StringEditor;
    SubKeg50Id: StringEditor;
    SubKeg50Kode: StringEditor;
}

export class SubKegiatanForm extends PrefixedContext {
    static readonly formKey = 'MasterData.SubKegiatan';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SubKegiatanForm.init)  {
            SubKegiatanForm.init = true;

            var w0 = StringEditor;

            initFormType(SubKegiatanForm, [
                'BidangView', w0,
                'UrusanView', w0,
                'ProgView', w0,
                'KegView', w0,
                'SubKegView', w0,
                'SubKeg50Id', w0,
                'SubKeg50Kode', w0
            ]);
        }
    }
}