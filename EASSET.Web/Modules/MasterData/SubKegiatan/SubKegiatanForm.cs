using Serenity.ComponentModel;

namespace EASSET.MasterData.Forms;

[FormScript("MasterData.SubKegiatan")]
[BasedOnRow(typeof(SubKegiatanRow), CheckNames = true)]
public class SubKegiatanForm
{
    public string BidangView { get; set; }
    public string UrusanView { get; set; }
    public string ProgView { get; set; }
    public string KegView { get; set; }
    public string SubKegView { get; set; }
    public string SubKeg50Id { get; set; }
    public string SubKeg50Kode { get; set; }
}