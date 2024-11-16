using Serenity.ComponentModel;
using System;

namespace EASSET.MasterData.Forms;

[FormScript("MasterData.Ruang")]
[BasedOnRow(typeof(RuangRow), CheckNames = true)]
public class RuangForm
{
    public string RuangKode { get; set; }
    public string RuangNama { get; set; }
    public string UnitId { get; set; }
    public string SubUnitId { get; set; }
    public string ThAng { get; set; }
    //public string Op { get; set; }
    //public DateTime Lu { get; set; }
    //public string Pc { get; set; }
    //public short Dlt { get; set; }
}