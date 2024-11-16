using EASSET.MasterData;
using Serenity.ComponentModel;
using System;

namespace EASSET.Perencanaan.Forms;

[FormScript("Perencanaan.RKBMD")]
[BasedOnRow(typeof(RKBMDRow), CheckNames = true)]
public class RKBMDForm
{
    //public string UnitId { get; set; }
    //public double NoUrut { get; set; }
    //public string Keterangan { get; set; }
    //public string ThAng { get; set; }
    //public string Op { get; set; }
    //public DateTime Lu { get; set; }
    //public string Pc { get; set; }
    //public short Dlt { get; set; }
    //public string SubUnitId { get; set; }
    public string KodeRekening { get; set; }
    public string NamaRekening { get; set; }
    [DisplayName("Jumlah Usulan")]
    public double JmlUsulan { get; set; }
    public double JmlKebMax { get; set; }
    public double JmlExisting { get; set; }
    public string SubKegNama { get; set; }
    [TextAreaEditor(Rows = 5, Cols = 10)]
    public string Keterangan { get; set; }
    [Hidden]
    public string SubSubRo108Id { get; set; }
    [Hidden]
    public string SubKegId { get; set; }
    [Hidden]
    public string SubKegKode { get; set; }
    //public string Satuan { get; set; }
    //public string Rkpdid { get; set; }
}