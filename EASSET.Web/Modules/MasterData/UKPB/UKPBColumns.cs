using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace EASSET.MasterData.Columns;

[ColumnsScript("MasterData.UKPB")]
[BasedOnRow(typeof(UKPBRow), CheckNames = true)]
public class UKPBColumns
{
    /*[EditLink, DisplayName("Db.Shared.RecordId"), AlignRigh]*/
    //public string Ukpbid { get; set; }
    [EditLink]
    public string UkpbNama { get; set; }
    public string UkpbKode { get; set; }
    public string UpbNama { get; set; }
    public string UnitNama { get; set; }
    public string SubUnitNama { get; set; }
    public string UkpbAlamat { get; set; }
    //public string ThAng { get; set; }
    //public string Op { get; set; }
    //public DateTime Lu { get; set; }
    //public string Pc { get; set; }
    //public short Dlt { get; set; }
}