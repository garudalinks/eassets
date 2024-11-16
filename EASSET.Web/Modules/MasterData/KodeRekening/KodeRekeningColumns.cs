using Serenity.ComponentModel;
using System.ComponentModel;

namespace EASSET.MasterData.Columns;

[ColumnsScript("MasterData.KodeRekening")]
[BasedOnRow(typeof(KodeRekeningRow), CheckNames = true)]
public class KodeRekeningColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public long Id { get; set; }
    //[EditLink]
    //public string Akun108Id { get; set; }
    //public string AkunView { get; set; }
    //public string Kelompok108Id { get; set; }
    //[DisplayName("Nama Kelompok")]
    //public string KelompokView { get; set; }
    ////public string Jenis108Id { get; set; }
    //[DisplayName("Jenis")]
    //public string JenisView { get; set; }
    ////public string Objek108Id { get; set; }
    //[DisplayName("Objek")]
    //public string ObjekView { get; set; }
    ////public string Ro108Id { get; set; }
    //[DisplayName("Ro")]
    //public string RoView { get; set; }
    ////public string SubRo108Id { get; set; }
    //[DisplayName("Sub Ro")]
    //public string SubRoView { get; set; }
    //public string SubSubRo108Id { get; set; }
    [SortOrder(1, false), DisplayName("Kode Rekening")]
    public string SubSubRoView { get; set; }
    //[DisplayName("Kode Rekening"), Width(1000)]
    //public string ThAng { get; set; }
    //public short IsEnabled { get; set; }
}