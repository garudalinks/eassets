using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TblKibBPengalihan
{
    public string KibBPengalihanId { get; set; }

    public string OpAdd { get; set; }

    public string PcAdd { get; set; }

    public DateTime? DateAdd { get; set; }

    public string OpEdit { get; set; }

    public string PcEdit { get; set; }

    public DateTime? DateEdit { get; set; }

    public byte? Dlt { get; set; }

    public string KibBId { get; set; }

    public string UnitId { get; set; }

    public string Tahun { get; set; }

    public string JenisPenggunaBarang { get; set; }

    public string AsalPenggunaBarangId { get; set; }

    public string AsalKodeBarang { get; set; }

    public string AsalKodeLokasi { get; set; }

    public double? PenerimaanJumlahBarang { get; set; }

    public string PenerimaanSatuan { get; set; }

    public double? PenerimaanHargaSatuan { get; set; }

    public double? PenerimaanTotalNilaiPerolehan { get; set; }

    public DateTime? PenerimaanTanggalPerolehan { get; set; }

    public double? PenerimaanPenyusutan { get; set; }

    public double? PenerimaanNilaiBuku { get; set; }

    public string DokSumberBastNomor { get; set; }

    public DateTime? DokSumberBastTanggal { get; set; }

    public string DokPendukungSppspNomor { get; set; }

    public DateTime? DokPendukungSppspTanggal { get; set; }

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
