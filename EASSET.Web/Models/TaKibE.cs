using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class TaKibE
{
    public string Idpemda { get; set; }

    public byte KdProv { get; set; }

    public byte KdKabKota { get; set; }

    public byte KdBidang { get; set; }

    public short KdUnit { get; set; }

    public short KdSub { get; set; }

    public int KdUpb { get; set; }

    public byte KdAset1 { get; set; }

    public byte KdAset2 { get; set; }

    public byte KdAset3 { get; set; }

    public byte KdAset4 { get; set; }

    public byte KdAset5 { get; set; }

    public int NoRegister { get; set; }

    public int? KdRuang { get; set; }

    public byte KdPemilik { get; set; }

    public DateTime TglPerolehan { get; set; }

    public string Judul { get; set; }

    public string Pencipta { get; set; }

    public string Bahan { get; set; }

    public string Ukuran { get; set; }

    public string AsalUsul { get; set; }

    public string Kondisi { get; set; }

    public decimal Harga { get; set; }

    public short? MasaManfaat { get; set; }

    public decimal? NilaiSisa { get; set; }

    public string Keterangan { get; set; }

    public short? Tahun { get; set; }

    public string NoSp2d { get; set; }

    public short? NoId { get; set; }

    public DateTime? TglPembukuan { get; set; }

    public short? KdKecamatan { get; set; }

    public short? KdDesa { get; set; }

    public byte? Invent { get; set; }

    public string NoSkguna { get; set; }

    public byte? KdPenyusutan { get; set; }

    public byte? KdData { get; set; }

    public string LogUser { get; set; }

    public DateTime? LogEntry { get; set; }

    public bool? KdKa { get; set; }

    public string NoSippt { get; set; }

    public short? DevId { get; set; }

    public bool KdHapus { get; set; }
}
