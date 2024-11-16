using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace EASSET.MasterData.Columns;

[ColumnsScript("MasterData.SubUnit")]
[BasedOnRow(typeof(SubUnitRow), CheckNames = true)]
public class SubUnitColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public string SubUnitId { get; set; }
    [EditLink]
    public string SubUnitNama { get; set; }
    public string SubUnitKode { get; set; }
    public string UnitNama { get; set; }
    //public string ThAng { get; set; }
    //public string Op { get; set; }
    //public DateTime Lu { get; set; }
    //public string Pc { get; set; }
    //public bool Dlt { get; set; }
    public string Alamat { get; set; }
    public string Npwp { get; set; }
}