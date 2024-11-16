using Serenity.ComponentModel;

namespace EASSET.MasterData.Forms;

[FormScript("MasterData.KodeRekening")]
[BasedOnRow(typeof(KodeRekeningRow), CheckNames = true)]
public class KodeRekeningForm
{
    public string Akun108Id { get; set; }
    public string AkunView { get; set; }
    public string Kelompok108Id { get; set; }
    public string KelompokView { get; set; }
    public string Jenis108Id { get; set; }
    public string JenisView { get; set; }
    public string Objek108Id { get; set; }
    public string ObjekView { get; set; }
    public string Ro108Id { get; set; }
    public string RoView { get; set; }
    public string SubRo108Id { get; set; }
    public string SubRoView { get; set; }
    public string SubSubRo108Id { get; set; }
    public string SubSubRoView { get; set; }
    public string KodeRekening108 { get; set; }
    public string ThAng { get; set; }
    public short IsEnabled { get; set; }
}