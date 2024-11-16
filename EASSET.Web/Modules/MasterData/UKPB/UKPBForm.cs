using Serenity.ComponentModel;
using System;

namespace EASSET.MasterData.Forms;

[FormScript("MasterData.UKPB")]
[BasedOnRow(typeof(UKPBRow), CheckNames = true)]
public class UKPBForm
{
    public string UnitId { get; set; }
    public string SubUnitId { get; set; }
    public string Upbid { get; set; }
    public string UkpbKode { get; set; }
    public string UkpbNama { get; set; }
    //public string ThAng { get; set; }
    [TextAreaEditor(Rows = 5, Cols =10)]
    public string UkpbAlamat { get; set; }
  
    //public string Op { get; set; }
    //public DateTime Lu { get; set; }
    //public string Pc { get; set; }
    //public short Dlt { get; set; }
}