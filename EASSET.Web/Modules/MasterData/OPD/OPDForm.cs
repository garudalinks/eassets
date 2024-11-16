using Serenity.ComponentModel;
using System;

namespace EASSET.MasterData.Forms;

[FormScript("MasterData.OPD")]
[BasedOnRow(typeof(OPDRow), CheckNames = true)]
public class OPDForm
{
    public string UnitKode { get; set; }
    public string UnitNama { get; set; }
    public string Npwp { get; set; }
    public short IsBlud { get; set; }
    public int NoUrut { get; set; }
    //public string ThAng { get; set; }
    [TextAreaEditor(Rows = 5, Cols = 10)]
    public string Alamat { get; set; }
    //public string Op { get; set; }
    //public DateTime Lu { get; set; }
    //public string Pc { get; set; }
    //public bool Dlt { get; set; }
}