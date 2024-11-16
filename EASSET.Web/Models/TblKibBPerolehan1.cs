using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TblKibBPerolehan1
{
    public string KibBPerolehan1Id { get; set; }

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

    public string BudgetId { get; set; }

    public string Subkeg50Id { get; set; }

    public string Subkeg50Kode { get; set; }

    public string Subkeg50Nama { get; set; }

    public string SubRo50id { get; set; }

    public string SubRo50kode { get; set; }

    public string SubRo50nama { get; set; }

    public string KodeRekening50 { get; set; }

    public double? JumlahBarang { get; set; }

    public string SatuanBarang { get; set; }

    public double? TotalNilaiBarang { get; set; }

    /// <summary>
    /// 1. Belanja Modal
    /// 2. Belanja Operasi
    /// 3. Belanja Tak Terduga
    /// </summary>
    public string JenisBelanja { get; set; }

    public string BastNomor { get; set; }

    public DateTime? BastTanggal { get; set; }

    public string KontrakPembayaranPenyedia { get; set; }

    public string KontrakPembayaranNomor { get; set; }

    public DateTime? KontrakPembayaranTanggal { get; set; }

    public string KontrakKuitansiPenyedia { get; set; }

    public string KontrakKuitansiNomor { get; set; }

    public DateTime? KontrakKuitansiTanggal { get; set; }

    public string KontrakSpkPenyedia { get; set; }

    public string KontrakSpkNomor { get; set; }

    public DateTime? KontrakSpkTanggal { get; set; }

    public string KontrakSperjanjianPenyedia { get; set; }

    public string KontrakSperjanjianNomor { get; set; }

    public DateTime? KontrakSperjanjianTanggal { get; set; }

    public string KontrakSpesananPenyedia { get; set; }

    public string KontrakSpesananNomor { get; set; }

    public DateTime? KontrakSpesananTanggal { get; set; }

    public string DokPendukungLainNomor1 { get; set; }

    public DateTime? DokPendukungLainTanggal1 { get; set; }

    public string DokPendukungLainNama1 { get; set; }

    public string DokPendukungLainNomor2 { get; set; }

    public DateTime? DokPendukungLainTanggal2 { get; set; }

    public string DokPendukungLainNama2 { get; set; }

    public string DokPendukungLainNomor3 { get; set; }

    public DateTime? DokPendukungLainTanggal3 { get; set; }

    public string DokPendukungLainNama3 { get; set; }

    public string AttribusiBudgetId { get; set; }

    public string AttribusiSubkeg50Id { get; set; }

    public string AttribusiSubkeg50Kode { get; set; }

    public string AttribusiSubkeg50Nama { get; set; }

    public string AttribusiSubRo50id { get; set; }

    public string AttribusiSubRo50kode { get; set; }

    public string AttribusiSubRo50nama { get; set; }

    public string AttribusiKodeRekening50 { get; set; }

    public string AttribusiNama1 { get; set; }

    public double? AttribusiNilai1 { get; set; }

    public string AttribusiNama2 { get; set; }

    public double? AttribusiNilai2 { get; set; }

    public string AttribusiNama3 { get; set; }

    public double? AttribusiNilai3 { get; set; }

    public string AttribusiNama4 { get; set; }

    public double? AttribusiNilai4 { get; set; }

    public string AttribusiNama5 { get; set; }

    public double? AttribusiNilai5 { get; set; }

    public string AttribusiBastNomor { get; set; }

    public DateTime? AttribusiBastTanggal { get; set; }

    public string AttribusiKontrakPembayaranPenyedia { get; set; }

    public string AttribusiKontrakPembayaranNomor { get; set; }

    public DateTime? AttribusiKontrakPembayaranTanggal { get; set; }

    public string AttribusiKontrakKuitansiPenyedia { get; set; }

    public string AttribusiKontrakKuitansiNomor { get; set; }

    public DateTime? AttribusiKontrakKuitansiTanggal { get; set; }

    public string AttribusiKontrakSpkPenyedia { get; set; }

    public string AttribusiKontrakSpkNomor { get; set; }

    public DateTime? AttribusiKontrakSpkTanggal { get; set; }

    public string AttribusiKontrakSperjanjianPenyedia { get; set; }

    public string AttribusiKontrakSperjanjianNomor { get; set; }

    public DateTime? AttribusiKontrakSperjanjianTanggal { get; set; }

    public string AttribusiKontrakSpesananPenyedia { get; set; }

    public string AttribusiDokPendukungLainNomor1 { get; set; }

    public DateTime? AttribusiDokPendukungLainTanggal1 { get; set; }

    public string AttribusiDokPendukungLainNama1 { get; set; }

    public string AttribusiDokPendukungLainNomor2 { get; set; }

    public DateTime? AttribusiDokPendukungLainTanggal2 { get; set; }

    public string AttribusiDokPendukungLainNama2 { get; set; }

    public string AttribusiDokPendukungLainNomor3 { get; set; }

    public DateTime? AttribusiDokPendukungLainTanggal3 { get; set; }

    public string AttribusiDokPendukungLainNama3 { get; set; }

    public double? NilaiPerolehanBarang { get; set; }

    public double? HargaSatuanPerolehan { get; set; }

    public string DiinputolehNama { get; set; }

    public string DiinputolehId { get; set; }

    public DateTime? DiinputolehTanggal { get; set; }
}
