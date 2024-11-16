using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace EASSET.Perencanaan.Columns;

[ColumnsScript("Perencanaan.RKBMD")]
[BasedOnRow(typeof(RKBMDRow), CheckNames = true)]
public class RKBMDColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public string Rkbmdid { get; set; }
    [SortOrder(1, descending: false)]
    public double NoUrut { get; set; }
    //public string SubKegId { get; set; }
    [EditLink]
    public string SubKegNama { get; set; }
    public string KodeRekening { get; set; }
    public string NamaRekening { get; set; }
    public double JmlKebMax { get; set; }
    //public string UnitId { get; set; }
    //public string ThAng { get; set; }
    //public string Op { get; set; }
    //public DateTime Lu { get; set; }
    //public string Pc { get; set; }
    //public short Dlt { get; set; }
    public double JmlExisting { get; set; }
    public double JmlUsulan { get; set; }
    //public string SubUnitId { get; set; }
    //public string SubKegKode { get; set; }
    //public string SubSubRo108Id { get; set; }
    //public string Satuan { get; set; }
    //public string Rkpdid { get; set; }
    public string Keterangan { get; set; }
}