using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace EASSET.MasterData.Columns;

[ColumnsScript("MasterData.Ruang")]
[BasedOnRow(typeof(RuangRow), CheckNames = true)]
public class RuangColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public string RuangId { get; set; 
    [EditLink]
    public string RuangNama { get; set; }
    [GroupOrder(1)]
    public string RuangKode { get; set; }
    [GroupOrder(2)]
    public string UnitNama { get; set; }
    public string SubUnitNama { get; set; }
    //public string ThAng { get; set; }
    //public string Op { get; set; }
    //public DateTime Lu { get; set; }
    //public string Pc { get; set; }
    //public short Dlt { get; set; }
}