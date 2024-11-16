using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EASSET.MasterData.Columns;

[ColumnsScript("MasterData.UPB")]
[BasedOnRow(typeof(UPBRow), CheckNames = true)]
public class UPBColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public string Upbid { get; set; }
    //public string UnitId { get; set;}
    [EditLink]
    public string UpbNama { get; set; }
    public string UpbKode { get; set; }
    public string UnitNama { get; set; }
    [Hidden]
    public string SubUnitNama { get; set; }
    //public string SubUnitId { get; set; }
    //public string ThAng { get; set; }
    //public string Op { get; set; }
    //public DateTime Lu { get; set; }
    //public string Pc { get; set; }
    //public short Dlt { get; set; }
}