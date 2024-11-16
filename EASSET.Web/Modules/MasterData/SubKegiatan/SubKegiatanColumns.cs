using Serenity.ComponentModel;
using System.ComponentModel;

namespace EASSET.MasterData.Columns;

[ColumnsScript("MasterData.SubKegiatan")]
[BasedOnRow(typeof(SubKegiatanRow), CheckNames = true)]
public class SubKegiatanColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public long Id { get; set; }
    //[EditLink]
    //[DisplayName("Nama Bidang")]
    //public string BidangView { get; set; }
    //[DisplayName("Nama Urusan")]
    //public string UrusanView { get; set; }
    //[DisplayName("Nama Program")]
    //public string ProgView { get; set; }
    [Hidden]
    [DisplayName("Nama Kegiatan"), SortOrder(1, false)]
    public string KegView { get; set; }
    [DisplayName("Nama SubKegiatan"), Width(1000)]
    public string SubKegView { get; set; }
    //public string SubKeg50Id { get; set; }
    //public string SubKeg50Kode { get; set; }
}