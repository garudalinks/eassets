using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace EASSET.MasterData.Columns;

[ColumnsScript("MasterData.OPD")]
[BasedOnRow(typeof(OPDRow), CheckNames = true)]
public class OPDColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public string UnitId { get; set; }
    [EditLink]
    public string UnitNama { get; set; }
    public string UnitKode { get; set; }
    //public string ThAng { get; set; }
    public string Alamat { get; set; }
    //public string Op { get; set; }
    //public DateTime Lu { get; set; }
    //public string Pc { get; set; }
    //public bool Dlt { get; set; }
    //public string Npwp { get; set; }
    //public short IsBlud { get; set; }
    //public int NoUrut { get; set; }
}