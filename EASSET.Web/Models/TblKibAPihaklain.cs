using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TblKibAPihaklain
{
    public string KibAPihaklainId { get; set; }

    public string OpAdd { get; set; }

    public string PcAdd { get; set; }

    public DateTime? DateAdd { get; set; }

    public string OpEdit { get; set; }

    public string PcEdit { get; set; }

    public DateTime? DateEdit { get; set; }

    public byte? Dlt { get; set; }

    public string KibAId { get; set; }

    public string UnitId { get; set; }

    public string Tahun { get; set; }

    public string JenisPenggunaBarang { get; set; }

    public string PihakLain { get; set; }

    public string Alamat { get; set; }

    public double? JumlahBarang { get; set; }

    public string Satuan { get; set; }

    public DateTime? TanggalMulai { get; set; }

    public DateTime? TanggalSelesai { get; set; }

    public string Peruntukan { get; set; }

    public string TanahBangunanDigunakan { get; set; }

    public string DokSkNomor { get; set; }

    public DateTime? DokSkTanggal { get; set; }

    public string DokSperjanjianNomor { get; set; }

    public DateTime? DokSperjanjianTanggal { get; set; }

    public string DokPendukungLainNomor1 { get; set; }

    public DateTime? DokPendukungLainTanggal1 { get; set; }

    public string DokPendukungLainNomor2 { get; set; }

    public DateTime? DokPendukungLainTanggal2 { get; set; }

    public string DokPendukungLainNomor3 { get; set; }

    public DateTime? DokPendukungLainTanggal3 { get; set; }

    public string DiinputolehNama { get; set; }

    public string DiinputolehId { get; set; }

    public DateTime? DiinputolehTanggal { get; set; }
}
