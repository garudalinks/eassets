using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TblKibB
{
    public string KibBId { get; set; }

    public string OpAdd { get; set; }

    public string PcAdd { get; set; }

    public DateTime? DateAdd { get; set; }

    public string OpEdit { get; set; }

    public string PcEdit { get; set; }

    public DateTime? DateEdit { get; set; }

    public byte? Dlt { get; set; }

    public string JenisPenggunaBarang { get; set; }

    public string UnitPenggunaBarangId { get; set; }

    public string UnitId { get; set; }

    public string Tahun { get; set; }

    public string UnitAlamat { get; set; }

    public string BarangKodeBarang { get; set; }

    public string BarangKodeLokasi { get; set; }

    public string BarangKodeRegBarang { get; set; }

    public string BarangNibar { get; set; }

    public string BarangNamaBarang { get; set; }

    public string BarangSpesifikasi { get; set; }

    public string BarangMerek { get; set; }

    public double? BarangMasamanfaat { get; set; }

    /// <summary>
    /// Baik, Rusak Ringan, Rusak Berat atau Usang
    /// </summary>
    public string BarangKondisiBarang { get; set; }

    public string BarangLokProvinsi { get; set; }

    public string BarangLokKabKota { get; set; }

    public string BarangLokKecamatanId { get; set; }

    public string BarangLokKecamatanNama { get; set; }

    public string BarangLokKelurahanDesaId { get; set; }

    public string BarangLokKelurahanDesaNama { get; set; }

    public string BarangLokJalan { get; set; }

    public string BarangLokRtRw { get; set; }

    public string BarangSpeklainNama1 { get; set; }

    public string BarangSpeklainNilai1 { get; set; }

    public string BarangSpeklainNama2 { get; set; }

    public string BarangSpeklainNilai2 { get; set; }

    public string BarangSpeklainNama3 { get; set; }

    public string BarangSpeklainNilai3 { get; set; }

    public string BarangSpeklainNama4 { get; set; }

    public string BarangSpeklainNilai4 { get; set; }

    public string BarangSpeklainNama5 { get; set; }

    public string BarangSpeklainNilai5 { get; set; }

    public string BarangCaraperolehan { get; set; }

    public string BarangKeterangan { get; set; }

    public string BarangFotoFile { get; set; }

    public string BarangDiinputolehNama { get; set; }

    public string BarangDiinputolehId { get; set; }

    public DateTime? BarangTanggalInput { get; set; }

    public DateTime? BarangTanggalPerolehan { get; set; }

    /// <summary>
    /// Bulan
    /// </summary>
    public double? BarangSisaMasamanfaat { get; set; }

    public string BarangNopol { get; set; }

    public string BarangNobpkb { get; set; }

    public string BarangNamapemilik { get; set; }

    public string BarangTipeKendaraan { get; set; }

    public string BarangJenisKendaraan { get; set; }

    public string BarangModelKendaraan { get; set; }

    public string BarangTahunPembuatan { get; set; }

    public string BarangIsiSilinder { get; set; }

    public string BarangNoRangka { get; set; }

    public string BarangNoMesin { get; set; }

    public string BarangWarna { get; set; }

    public string BarangWarnaTnkb { get; set; }

    public string BarangNoHpGps { get; set; }
}
