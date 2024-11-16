using Serenity.ComponentModel;
using System;

namespace EASSET.MasterData.Forms;

[FormScript("MasterData.SubUnit")]
[BasedOnRow(typeof(SubUnitRow), CheckNames = true)]
public class SubUnitForm
{
    public string UnitId { get; set; }
    public string SubUnitKode { get; set; }
    public string SubUnitNama { get; set; }
    public string Npwp { get; set; }
    //public string ThAng { get; set; }
    //public string Op { get; set; }
    //public DateTime Lu { get; set; }
    //public string Pc { get; set; }
    //public bool Dlt { get; set; }
    [TextAreaEditor(Rows =5, Cols =10)]
    public string Alamat { get; set; }
 
}