using EASSET.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serenity.Web;
using System.Data;
using System.IO;
using EASSET.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using static Serenity.Web.LookupScript;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace EASSET.Penatausahaan.Pages;

public class MesinPage : Controller
{
    private IWebHostEnvironment Environment;
    private readonly string _connectionstring;
    public MesinPage(IWebHostEnvironment _environment, IConfiguration configuration)
    {
        Environment = _environment;
        _connectionstring = configuration["Data:Default:ConnectionString"];
    }


    [Route("Penatausahaan/Mesin")]
    public ActionResult Index()
    {
        string strSql = "select UnitID, UnitNama, Alamat from tbmUnit where DLT='0' ORDER BY UnitNama";
        string strSqlKecamatan = "select a.kecamatan_id, a.kode, a.nama from INFIS_TPP_2020.dbo.m_kecamatan a where a.dlt='0' order by a.kode";
        string strSqlKelurahan = "select a.kecamatan_id, a.kode as kecamatan_kode, a.nama as kecamatan_nama, b.kelurahan_id, b.kode, b.nama, b.kelurahan_id+'_'+b.nama as kel_nama from INFIS_TPP_2020.dbo.m_kecamatan a inner join INFIS_TPP_2020.dbo.m_kelurahan b on a.kecamatan_id=b.kecamatan_id and b.dlt='0'where a.dlt='0'order by a.kode, b.kode";

        DataTable dtUnit = clsGlobal.getData(strSql);
        DataTable dtKecamatan = clsGlobal.getData(strSqlKecamatan);
        DataTable dtKelurahan = clsGlobal.getData(strSqlKelurahan);
        DataTable dtPenggunaBarang = clsGlobal.getNamaPenggunaBarang();

        ViewBag.dtUnit = dtUnit;
        ViewBag.dtKec = dtKecamatan;
        ViewBag.dtKel = dtKelurahan;
        ViewBag.dtPenggunaBarang = dtPenggunaBarang;

        return View();
    }
    [Route("Mesin/GetDataAset")]
    public JsonResult Get()
    {
        string strSql = "select kib_b_id,jenis_pengguna_barang,barang_nama_barang, barang_caraperolehan,barang_nibar,coalesce(barang_no_hp_gps, '') as barang_no_hp_gps, CASE WHEN barang_lok_kecamatan_id <> '' THEN CASE WHEN barang_lok_kelurahan_desa_id <> '' THEN CASE WHEN barang_lok_jalan <> '' THEN CASE WHEN barang_lok_rt_rw <> '' THEN barang_lok_provinsi+','+barang_lok_kab_kota+'<br>'+barang_lok_kecamatan_nama+'<br>'+barang_lok_kelurahan_desa_nama+'<br>'+barang_lok_jalan+'<br>'+barang_lok_rt_rw ELSE barang_lok_provinsi+','+barang_lok_kab_kota+'<br>'+barang_lok_kecamatan_nama+'<br>'+barang_lok_kelurahan_desa_nama+'<br>'+barang_lok_jalan END ELSE barang_lok_provinsi+','+barang_lok_kab_kota+'<br>'+barang_lok_kecamatan_nama+'<br>'+barang_lok_kelurahan_desa_nama END ELSE barang_lok_provinsi+','+barang_lok_kab_kota+'<br>'+barang_lok_kecamatan_nama END ELSE barang_lok_provinsi+','+barang_lok_kab_kota END AS barang_lokasi from tbl_kib_b where dlt=0";

        DataTable dtData = clsGlobal.getData(strSql);
        string strResult = clsGlobal.DataTableToJSON(dtData);
        return Json(strResult);
    }

    [Route("MesinPage/GetSubKegiatan/{unitID}")]
    public JsonResult GetSubKegiatan([FromRoute] string unitID)
    {
        string strResult = "error";
        DataTable dtData = new DataTable();

        using (var connection = new SqlConnection(_connectionstring))
        {
            var command = new SqlCommand("select a.UnitID, a.Kode+' '+a.UnitNama as UnitView,coalesce(a.SubUnitID,'') as SubUnitID, coalesce(a.SubUnitKode,'')+' '+coalesce(a.SubUnitNama,'') as SubUnitView,a.Urusan50ID, a.Urusan50Kode+' '+a.Urusan50Nama as Urusan50View, a.Bidang50ID, a.Bidang50Kode+' '+a.Bidang50Nama as Bidang50View,a.Prog50ID, a.Bidang50Kode+a.Prog50Kode+' '+a.Prog50Nama as Prog50View,a.Keg50ID, a.Bidang50Kode+a.Prog50Kode+a.Keg50Kode+' '+a.Keg50Nama as Keg50View,a.SubKeg50ID, a.Bidang50Kode+a.Prog50Kode+a.Keg50Kode+a.SubKeg50Kode+' '+a.SubKeg50Nama as SubKeg50View from [10.20.30.1\\MSSQLSERVER08R2].INFIS_2024.dbo.tbsBudgetAll a where a.UnitID=@unitID and a.dlt='0' and coalesce(a.Prog50Nama,'')<>'' order by UnitView, Urusan50View, Bidang50View, Prog50View, Keg50View, SubKeg50View;", connection);

            command.Parameters.AddWithValue("@unitID", unitID);

            using (var adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dtData);
                strResult = clsGlobal.DataTableToJSON(dtData);
            }
        }
        return Json(new { data = strResult });
    }

    [Route("MesinPage/GetMesin/{nibar}")]
    public JsonResult GetMesin([FromRoute] string nibar)
    {
        string strResult = "error";

        DataTable dtData = new DataTable();

        using (var connection = new SqlConnection(_connectionstring))
        {
            var command = new SqlCommand("select a.kib_b_id,b.kib_b_perolehan1_id, a.jenis_pengguna_barang, a.unit_pengguna_barang_id, a.unitID, a.tahun, a.unit_alamat, a.barang_kode_barang, a.barang_kode_lokasi,a.barang_lok_kecamatan_nama,a.barang_lok_kelurahan_desa_nama , a.barang_kode_reg_barang, a.barang_nibar, a.barang_nama_barang, a.barang_spesifikasi, a.barang_merek, a.barang_masamanfaat, a.barang_kondisi_barang, a.barang_lok_kecamatan_id, a.barang_lok_kelurahan_desa_id,a.barang_lok_jalan, a.barang_lok_rt_rw, a.barang_speklain_nama1, a.barang_speklain_nilai1,a.barang_speklain_nama2, a.barang_speklain_nilai2,a.barang_speklain_nama3, a.barang_speklain_nilai3,a.barang_speklain_nama4, a.barang_speklain_nilai4,a.barang_speklain_nama5, a.barang_speklain_nilai5, a.barang_caraperolehan, a.barang_keterangan, a.barang_foto_file, a.barang_diinputoleh_id,a.barang_diinputoleh_nama, format(a.barang_tanggal_input, 'yyyy-MM-dd') as barang_tanggal_input, format(a.barang_tanggal_perolehan, 'yyyy-MM-dd') as barang_tanggal_perolehan, a.barang_sisa_masamanfaat, a.barang_nopol, a.barang_nobpkb, a.barang_namapemilik, a.barang_tipe_kendaraan, a.barang_jenis_kendaraan, a.barang_model_kendaraan, a.barang_tahun_pembuatan, a.barang_isi_silinder, a.barang_no_rangka, a.barang_no_mesin, a.barang_warna, a.barang_warna_tnkb, a.barang_no_hp_gps,b.jenis_belanja,b.Subkeg50ID,b.Subkeg50Kode,b.Subkeg50Nama,b.SubRO50ID,b.SubRO50kode,b.SubRO50Nama,b.KodeRekening50,b.satuan_barang,b.jumlah_barang,b.total_nilai_barang,b.bast_nomor,format(b.bast_tanggal, 'yyyy-MM-dd') as bast_tanggal,b.kontrak_pembayaran_penyedia,b.kontrak_pembayaran_nomor,format(b.kontrak_pembayaran_tanggal, 'yyyy-MM-dd') as kontrak_pembayaran_tanggal,b.kontrak_kuitansi_penyedia,b.kontrak_kuitansi_nomor,format(b.kontrak_kuitansi_tanggal, 'yyyy-MM-dd') as kontrak_kuitansi_tanggal,b.kontrak_spk_penyedia,b.kontrak_spk_nomor,format(b.kontrak_spk_tanggal, 'yyyy-MM-dd') as kontrak_spk_tanggal,b.kontrak_sperjanjian_penyedia,b.kontrak_sperjanjian_nomor,format(b.kontrak_sperjanjian_tanggal, 'yyyy-MM-dd') as kontrak_sperjanjian_tanggal,b.kontrak_spesanan_penyedia,b.kontrak_spesanan_nomor,format(b.kontrak_spesanan_tanggal, 'yyyy-MM-dd') as kontrak_spesanan_tanggal,b.dok_pendukung_lain_nomor1,format(b.dok_pendukung_lain_tanggal1, 'yyyy-MM-dd') as dok_pendukung_lain_tanggal1,b.dok_pendukung_lain_nama1,b.dok_pendukung_lain_nomor2,format(b.dok_pendukung_lain_tanggal2, 'yyyy-MM-dd') as dok_pendukung_lain_tanggal2,b.dok_pendukung_lain_nama2,b.dok_pendukung_lain_nomor3,format(b.dok_pendukung_lain_tanggal3, 'yyyy-MM-dd') as dok_pendukung_lain_tanggal3,b.dok_pendukung_lain_nama3,b.attribusi_Subkeg50ID,b.attribusi_Subkeg50Kode,b.attribusi_Subkeg50Nama,b.attribusi_SubRO50ID,b.attribusi_SubRO50Kode,b.attribusi_SubRO50Nama,b.attribusi_KodeRekening50,b.attribusi_nama1,b.attribusi_nilai1,b.attribusi_nama2,b.attribusi_nilai2,b.attribusi_nama3,b.attribusi_nilai3,b.attribusi_nama4,b.attribusi_nilai4,b.attribusi_nilai5,b.attribusi_bast_nomor,format(b.attribusi_bast_tanggal, 'yyyy-MM-dd') as attribusi_bast_tanggal,b.attribusi_kontrak_pembayaran_penyedia,b.attribusi_kontrak_pembayaran_nomor,format(b.attribusi_kontrak_pembayaran_tanggal, 'yyyy-MM-dd') as attribusi_kontrak_pembayaran_tanggal,b.attribusi_kontrak_kuitansi_penyedia,b.attribusi_kontrak_kuitansi_nomor,format(b.attribusi_kontrak_kuitansi_tanggal, 'yyyy-MM-dd') as attribusi_kontrak_kuitansi_tanggal,b.attribusi_kontrak_spk_penyedia,b.attribusi_kontrak_spk_nomor,format(b.attribusi_kontrak_spk_tanggal, 'yyyy-MM-dd') as attribusi_kontrak_spk_tanggal,b.attribusi_kontrak_sperjanjian_penyedia,b.attribusi_kontrak_sperjanjian_nomor,format(b.attribusi_kontrak_sperjanjian_tanggal, 'yyyy-MM-dd') as attribusi_kontrak_sperjanjian_tanggal,b.attribusi_kontrak_spesanan_penyedia,b.attribusi_dok_pendukung_lain_nomor1,format(b.attribusi_dok_pendukung_lain_tanggal1, 'yyyy-MM-dd') as attribusi_dok_pendukung_lain_tanggal1,b.attribusi_dok_pendukung_lain_nama1,b.attribusi_dok_pendukung_lain_nomor2,format(b.attribusi_dok_pendukung_lain_tanggal2, 'yyyy-MM-dd') as attribusi_dok_pendukung_lain_tanggal2,b.attribusi_dok_pendukung_lain_nama2,b.attribusi_dok_pendukung_lain_nomor3,format(b.attribusi_dok_pendukung_lain_tanggal3, 'yyyy-MM-dd') as attribusi_dok_pendukung_lain_tanggal3,b.attribusi_dok_pendukung_lain_nama3,b.nilai_perolehan_barang,b.harga_satuan_perolehan,b.diinputoleh_nama,b.diinputoleh_id,format(b.diinputoleh_tanggal, 'yyyy-MM-dd') as diinputoleh_tanggal  \nfrom tbl_kib_b a\nleft join tbl_kib_b_perolehan_1 b on a.kib_b_id = b.kib_b_id \nwhere a.barang_nibar=@nibar and a.dlt='';", connection);

            command.Parameters.AddWithValue("@nibar", nibar);

            using (var adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dtData); 
                strResult = clsGlobal.DataTableToJSON(dtData);
            }
        }
        return Json(new { data = strResult });
    }

    [HttpPost]
    [Route("MesinPage/SaveMesin")]
    public JsonResult SaveMesin()
    {
        string strResult = "Error";
        try
        {
            using(EassetContext db = new EassetContext())
            {
                using(var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        string strID = Request.Form["kib_b_id"] + "";
                        string strIDPerolehan1 = Request.Form["kib_b_perolehan1_id"] + "";

                        TblKibB oObject;

                        if (string.IsNullOrEmpty(strID))
                        {
                            oObject = new TblKibB();
                            oObject.KibBId = clsGlobal.getNewID();
                            oObject.BarangNibar = clsGlobal.getNewID();
                            oObject.Dlt = 0;
                            oObject.OpAdd = "admin";
                            oObject.PcAdd = clsGlobal.GetIPAddr();
                            oObject.DateAdd = clsGlobal.getServerDate();
                            db.TblKibBs.Add(oObject);
                        }
                        else
                        {
                            oObject = db.TblKibBs.Find(strID);
                            oObject.OpEdit = "admin";
                            oObject.PcEdit = clsGlobal.GetIPAddr();
                            oObject.DateEdit = clsGlobal.getServerDate();
                        }

                        if (oObject != null)
                        {
                            oObject.UnitId = Request.Form["UnitID"] + "";
                            oObject.JenisPenggunaBarang = Request.Form["jenis_pengguna_barang"] + "";
                            oObject.UnitPenggunaBarangId = Request.Form["unit_pengguna_barang_id"] + "";
                            oObject.Tahun = Request.Form["tahun"] + "";
                            oObject.UnitAlamat = Request.Form["unit_alamat"] + "";
                            oObject.BarangKodeBarang = Request.Form["barang_kode_barang"] + "";
                            oObject.BarangKodeLokasi = Request.Form["barang_kode_lokasi"] + "";
                            oObject.BarangKodeRegBarang = Request.Form["barang_kode_reg_barang"] + "";
                            oObject.BarangNamaBarang = Request.Form["barang_nama_barang"] + "";
                            oObject.BarangSpesifikasi = Request.Form["barang_spesifikasi"] + "";
                            oObject.BarangMerek = Request.Form["barang_merek"] + "";
                            oObject.BarangMasamanfaat = Request.Form["barang_masamanfaat"] + "" != "" ? Convert.ToDouble(Request.Form["barang_masamanfaat"] + "") : null;
                            oObject.BarangKondisiBarang = Request.Form["barang_kondisi_barang"] + "";
                            oObject.BarangLokProvinsi = "Kepulauan Riau";
                            oObject.BarangLokKabKota = "Natuna";
                            oObject.BarangLokKecamatanId = Request.Form["barang_lok_kecamatan_id"] + "";
                            oObject.BarangLokKecamatanNama = Request.Form["barang_lok_kecamatan_nama"] + "";
                            oObject.BarangLokKelurahanDesaId = Request.Form["barang_lok_kelurahan_desa_id"] + "";
                            oObject.BarangLokKelurahanDesaNama = Request.Form["barang_lok_kelurahan_desa_nama"] + "";
                            oObject.BarangLokJalan = Request.Form["barang_lok_jalan"] + "";
                            oObject.BarangLokRtRw = Request.Form["barang_lok_rt_rw"] + "";
                            oObject.BarangSpeklainNama1 = Request.Form["barang_speklain_nama1"] + "";
                            oObject.BarangSpeklainNilai1 = Request.Form["barang_speklain_nilai1"] + "";
                            oObject.BarangSpeklainNama2 = Request.Form["barang_speklain_nama2"] + "";
                            oObject.BarangSpeklainNilai2 = Request.Form["barang_speklain_nilai2"] + "";
                            oObject.BarangSpeklainNama3 = Request.Form["barang_speklain_nama3"] + "";
                            oObject.BarangSpeklainNilai3 = Request.Form["barang_speklain_nilai3"] + "";
                            oObject.BarangSpeklainNama4 = Request.Form["barang_speklain_nama4"] + "";
                            oObject.BarangSpeklainNilai4 = Request.Form["barang_speklain_nilai4"] + "";
                            oObject.BarangSpeklainNama5 = Request.Form["barang_speklain_nama5"] + "";
                            oObject.BarangSpeklainNilai5 = Request.Form["barang_speklain_nilai5"] + "";
                            oObject.BarangSisaMasamanfaat = Request.Form["barang_sisa_masamanfaat"] + "" != "" ? Convert.ToDouble(Request.Form["barang_sisa_masamanfaat"] + "") : null;
                            oObject.BarangNopol = Request.Form["barang_nopol"] + "";
                            oObject.BarangNobpkb = Request.Form["barang_nobpkb"] + "";
                            oObject.BarangNamapemilik = Request.Form["barang_namapemilik"] + "";
                            oObject.BarangTipeKendaraan = Request.Form["barang_tipe_kendaraan"] + "";
                            oObject.BarangJenisKendaraan = Request.Form["barang_jenis_kendaraan"] + "";
                            oObject.BarangModelKendaraan = Request.Form["barang_model_kendaraan"] + "";
                            oObject.BarangTahunPembuatan = Request.Form["barang_tahun_pembuatan"] + "";
                            oObject.BarangIsiSilinder = Request.Form["barang_isi_silinder"] + "";
                            oObject.BarangNoRangka = Request.Form["barang_no_rangka"] + "";
                            oObject.BarangNoMesin = Request.Form["barang_no_mesin"] + "";
                            oObject.BarangWarna = Request.Form["barang_warna"] + "";
                            oObject.BarangWarnaTnkb = Request.Form["barang_warna_tnkb"] + "";
                            oObject.BarangNoHpGps = Request.Form["barang_no_hp_gps"] + "";
                            oObject.BarangCaraperolehan = Request.Form["barang_caraperolehan"] + "";
                            oObject.BarangKeterangan = Request.Form["barang_keterangan"] + "";
                            oObject.BarangDiinputolehNama = Request.Form["barang_diinputoleh_nama"] + "";
                            oObject.BarangDiinputolehId = Request.Form["barang_diinputoleh_id"] + "";
                            oObject.BarangTanggalInput = Request.Form["barang_tanggal_input"] + "" != "" ? Convert.ToDateTime(Request.Form["barang_tanggal_input"] + "") : null;
                            oObject.BarangTanggalPerolehan = Request.Form["barang_tanggal_perolehan"] + "" != "" ? Convert.ToDateTime(Request.Form["barang_tanggal_perolehan"] + "") : null;


                            var files = Request.Form.Files;
                            long size = files.Sum(f => f.Length);

                            string strPathServer = Path.GetTempPath();

                            var folderPath = Path.Combine(Environment.WebRootPath, "assets/Mesin/Photos/" + oObject.KibBId + "/");

                            foreach (var formFile in files)
                            {
                                if (formFile.Length > 0)
                                {
                                    if (formFile.Name == "barang_foto_file")
                                    {
                                        if (!Directory.Exists(folderPath))
                                        {
                                            Directory.CreateDirectory(folderPath);
                                        }
                                        string strExt = Path.GetExtension(formFile.FileName);
                                        string strFileName = oObject.KibBId + strExt;
                                        var filePath = Path.Combine(folderPath, strFileName);
                                        using (var stream = new FileStream(filePath, FileMode.Create))
                                        {
                                            formFile.CopyTo(stream);
                                            oObject.BarangFotoFile = strFileName;
                                        }
                                    }
                                }
                            }
                            //db.SaveChanges();
                            //strResult = "success";
                        }

                        if (Request.Form["barang_caraperolehan"] + "" == "pengadaan barang yang dibeli atau diperoleh atas beban APBD")
                        {
                            TblKibBPerolehan1 oObjectPerolehan1;

                            if (string.IsNullOrEmpty(strIDPerolehan1))
                            {
                                oObjectPerolehan1 = new TblKibBPerolehan1();
                                oObjectPerolehan1.KibBPerolehan1Id = clsGlobal.getNewID();
                                oObjectPerolehan1.KibBId = oObject.KibBId;
                                oObjectPerolehan1.BudgetId = clsGlobal.getNewID();
                                oObjectPerolehan1.AttribusiBudgetId = clsGlobal.getNewID();
                                oObjectPerolehan1.Dlt = 0;
                                oObjectPerolehan1.OpAdd = "admin";
                                oObjectPerolehan1.PcAdd = clsGlobal.GetIPAddr();
                                oObjectPerolehan1.DateAdd = clsGlobal.getServerDate();
                                db.TblKibBPerolehan1s.Add(oObjectPerolehan1);
                            }
                            else
                            {
                                oObjectPerolehan1 = db.TblKibBPerolehan1s.Find(strIDPerolehan1);
                                oObjectPerolehan1.OpEdit = "admin";
                                oObjectPerolehan1.PcEdit = clsGlobal.GetIPAddr();
                                oObjectPerolehan1.DateEdit = clsGlobal.getServerDate();
                            }

                            if (oObject != null)
                            {
                                oObjectPerolehan1.Tahun = Request.Form["tahun"] + "";
                                oObjectPerolehan1.UnitId = Request.Form["UnitID"] + "";
                                oObjectPerolehan1.JenisPenggunaBarang = Request.Form["jenis_pengguna_barang"] + "";
                                oObjectPerolehan1.Tahun = Request.Form["tahun"] + "";
                                oObjectPerolehan1.Subkeg50Id = Request.Form["Subkeg50ID"] + "";
                                oObjectPerolehan1.Subkeg50Kode = Request.Form["Subkeg50Kode"] + "";
                                oObjectPerolehan1.Subkeg50Nama = Request.Form["Subkeg50Nama"] + "";
                                oObjectPerolehan1.SubRo50id = Request.Form["SubRO50ID"] + "";
                                oObjectPerolehan1.SubRo50kode = Request.Form["SubRO50kode"] + "";
                                oObjectPerolehan1.SubRo50nama = Request.Form["SubRO50nama"] + "";
                                oObjectPerolehan1.KodeRekening50 = Request.Form["KodeRekening50"] + "";
                                oObjectPerolehan1.JumlahBarang = Request.Form["jumlah_barang"] + "" != "" ? Convert.ToDouble(Request.Form["jumlah_barang"] + "") : null;
                                oObjectPerolehan1.SatuanBarang = Request.Form["satuan_barang"] + "";
                                oObjectPerolehan1.TotalNilaiBarang = Request.Form["total_nilai_barang"] + "" != "" ? Convert.ToDouble(Request.Form["total_nilai_barang"] + "") : null;
                                oObjectPerolehan1.JenisBelanja = Request.Form["jenis_belanja"] + "";
                                oObjectPerolehan1.BastNomor = Request.Form["bast_nomor"] + "";
                                oObjectPerolehan1.BastTanggal = Request.Form["bast_tanggal"] + "" != "" ? Convert.ToDateTime(Request.Form["bast_tanggal"] + "") : null;
                                oObjectPerolehan1.KontrakPembayaranPenyedia = Request.Form["kontrak_pembayaran_penyedia"] + "";
                                oObjectPerolehan1.KontrakPembayaranNomor = Request.Form["kontrak_pembayaran_nomor"] + "";
                                oObjectPerolehan1.KontrakPembayaranTanggal = Request.Form["kontrak_pembayaran_tanggal"] + "" != "" ? Convert.ToDateTime(Request.Form["kontrak_pembayaran_tanggal"] + "") : null;
                                oObjectPerolehan1.KontrakKuitansiPenyedia = Request.Form["kontrak_kuitansi_penyedia"] + "";
                                oObjectPerolehan1.KontrakKuitansiNomor = Request.Form["kontrak_kuitansi_nomor"] + "";
                                oObjectPerolehan1.KontrakKuitansiTanggal = Request.Form["kontrak_kuitansi_tanggal"] + "" != "" ? Convert.ToDateTime(Request.Form["kontrak_kuitansi_tanggal"] + "") : null;
                                oObjectPerolehan1.KontrakSpkPenyedia = Request.Form["kontrak_spk_penyedia"] + "";
                                oObjectPerolehan1.KontrakSpkNomor = Request.Form["kontrak_spk_nomor"] + "";
                                oObjectPerolehan1.KontrakSpkTanggal = Request.Form["kontrak_spk_tanggal"] + "" != "" ? Convert.ToDateTime(Request.Form["kontrak_spk_tanggal"] + "") : null;
                                oObjectPerolehan1.KontrakSperjanjianPenyedia = Request.Form["kontrak_sperjanjian_penyedia"] + "";
                                oObjectPerolehan1.KontrakSperjanjianNomor = Request.Form["kontrak_sperjanjian_nomor"] + "";
                                oObjectPerolehan1.KontrakSperjanjianTanggal = Request.Form["kontrak_sperjanjian_tanggal"] + "" != "" ? Convert.ToDateTime(Request.Form["kontrak_sperjanjian_tanggal"] + "") : null;
                                oObjectPerolehan1.KontrakSpesananPenyedia = Request.Form["kontrak_spesanan_penyedia"] + "";
                                oObjectPerolehan1.KontrakSpesananNomor = Request.Form["kontrak_spesanan_nomor"] + "";
                                oObjectPerolehan1.KontrakSpesananTanggal = Request.Form["kontrak_spesanan_tanggal"] + "" != "" ? Convert.ToDateTime(Request.Form["kontrak_spesanan_tanggal"] + "") : null;
                                oObjectPerolehan1.DokPendukungLainNomor1 = Request.Form["dok_pendukung_lain_nomor1"] + "";
                                oObjectPerolehan1.DokPendukungLainTanggal1 = Request.Form["dok_pendukung_lain_tanggal1"] + "" != "" ? Convert.ToDateTime(Request.Form["dok_pendukung_lain_tanggal1"]) : null;
                                oObjectPerolehan1.DokPendukungLainNama1 = Request.Form["dok_pendukung_lain_nama1"] + "";
                                oObjectPerolehan1.DokPendukungLainNomor2 = Request.Form["dok_pendukung_lain_nomor2"] + "";
                                oObjectPerolehan1.DokPendukungLainTanggal2 = Request.Form["dok_pendukung_lain_tanggal2"] + "" != "" ? Convert.ToDateTime(Request.Form["dok_pendukung_lain_tanggal2"]) : null;
                                oObjectPerolehan1.DokPendukungLainNama2 = Request.Form["dok_pendukung_lain_nama2"] + "";
                                oObjectPerolehan1.DokPendukungLainNomor3 = Request.Form["dok_pendukung_lain_nomor3"] + "";
                                oObjectPerolehan1.DokPendukungLainTanggal3 = Request.Form["dok_pendukung_lain_tanggal3"] + "" != "" ? Convert.ToDateTime(Request.Form["dok_pendukung_lain_tanggal3"]) : null;
                                oObjectPerolehan1.DokPendukungLainNama3 = Request.Form["dok_pendukung_lain_nama3"] + "";
                                oObjectPerolehan1.AttribusiSubkeg50Id = Request.Form["attribusi_Subkeg50ID"] + "";
                                oObjectPerolehan1.AttribusiSubkeg50Kode = Request.Form["attribusi_Subkeg50Kode"] + "";
                                oObjectPerolehan1.AttribusiSubkeg50Nama = Request.Form["attribusi_Subkeg50Nama"] + "";
                                oObjectPerolehan1.AttribusiSubRo50id = Request.Form["attribusi_SubRO50ID"] + "";
                                oObjectPerolehan1.AttribusiSubRo50kode = Request.Form["attribusi_SubRO50Kode"] + "";
                                oObjectPerolehan1.AttribusiSubRo50nama = Request.Form["attribusi_SubRO50Nama"] + "";
                                oObjectPerolehan1.AttribusiKodeRekening50 = Request.Form["attribusi_KodeRekening50"] + "";
                                oObjectPerolehan1.AttribusiNama1 = Request.Form["attribusi_nama1"] + "";
                                oObjectPerolehan1.AttribusiNilai1 = Request.Form["attribusi_nilai1"] + "" != "" ? Convert.ToDouble(Request.Form["attribusi_nilai1"] + "") : null;
                                oObjectPerolehan1.AttribusiNama2 = Request.Form["attribusi_nama2"] + "";
                                oObjectPerolehan1.AttribusiNilai2 = Request.Form["attribusi_nilai2"] + "" != "" ? Convert.ToDouble(Request.Form["attribusi_nilai2"] + "") : null;
                                oObjectPerolehan1.AttribusiNama3 = Request.Form["attribusi_nama3"] + "";
                                oObjectPerolehan1.AttribusiNilai3 = Request.Form["attribusi_nilai3"] + "" != "" ? Convert.ToDouble(Request.Form["attribusi_nilai3"] + "") : null;
                                oObjectPerolehan1.AttribusiNama4 = Request.Form["attribusi_nama4"] + "";
                                oObjectPerolehan1.AttribusiNilai4 = Request.Form["attribusi_nilai4"] + "" != "" ? Convert.ToDouble(Request.Form["attribusi_nilai4"] + "") : null;
                                oObjectPerolehan1.AttribusiNama5 = Request.Form["attribusi_nama5"] + "";
                                oObjectPerolehan1.AttribusiNilai5 = Request.Form["attribusi_nilai5"] + "" != "" ? Convert.ToDouble(Request.Form["attribusi_nilai5"] + "") : null;
                                oObjectPerolehan1.AttribusiBastNomor = Request.Form["attribusi_bast_nomor"] + "";
                                oObjectPerolehan1.AttribusiBastTanggal = Request.Form["attribusi_bast_tanggal"] + "" != "" ? Convert.ToDateTime(Request.Form["attribusi_bast_tanggal"] + "") : null;
                                oObjectPerolehan1.AttribusiKontrakPembayaranPenyedia = Request.Form["attribusi_kontrak_pembayaran_penyedia"] + "";
                                oObjectPerolehan1.AttribusiKontrakPembayaranNomor = Request.Form["attribusi_kontrak_pembayaran_nomor"] + "";
                                oObjectPerolehan1.AttribusiKontrakPembayaranTanggal = Request.Form["attribusi_kontrak_pembayaran_tanggal"] + "" != "" ? Convert.ToDateTime(Request.Form["attribusi_kontrak_pembayaran_tanggal"] + "") : null;
                                oObjectPerolehan1.AttribusiKontrakKuitansiPenyedia = Request.Form["attribusi_kontrak_kuitansi_penyedia"] + "";
                                oObjectPerolehan1.AttribusiKontrakKuitansiNomor = Request.Form["attribusi_kontrak_kuitansi_nomor"] + "";
                                oObjectPerolehan1.AttribusiKontrakKuitansiTanggal = Request.Form["attribusi_kontrak_kuitansi_tanggal"] + "" != "" ? Convert.ToDateTime(Request.Form["attribusi_kontrak_kuitansi_tanggal"] + "") : null;
                                oObjectPerolehan1.AttribusiKontrakSpkPenyedia = Request.Form["attribusi_kontrak_spk_penyedia"] + "";
                                oObjectPerolehan1.AttribusiKontrakSpkNomor = Request.Form["attribusi_kontrak_spk_nomor"] + "";
                                oObjectPerolehan1.AttribusiKontrakSpkTanggal = Request.Form["attribusi_kontrak_spk_tanggal"] + "" != "" ? Convert.ToDateTime(Request.Form["attribusi_kontrak_spk_tanggal"] + "") : null;
                                oObjectPerolehan1.AttribusiKontrakSperjanjianPenyedia = Request.Form["attribusi_kontrak_sperjanjian_penyedia"] + "";
                                oObjectPerolehan1.AttribusiKontrakSperjanjianNomor = Request.Form["attribusi_kontrak_sperjanjian_nomor"] + "";
                                oObjectPerolehan1.AttribusiKontrakSperjanjianTanggal = Request.Form["attribusi_kontrak_sperjanjian_tanggal"] + "" != "" ? Convert.ToDateTime(Request.Form["attribusi_kontrak_sperjanjian_tanggal"] + "") : null;
                                oObjectPerolehan1.AttribusiKontrakSpesananPenyedia = Request.Form["attribusi_kontrak_spesanan_penyedia"] + "";
                                oObjectPerolehan1.AttribusiDokPendukungLainNomor1 = Request.Form["attribusi_dok_pendukung_lain_nomor1"] + "";
                                oObjectPerolehan1.AttribusiDokPendukungLainTanggal1 = Request.Form["attribusi_dok_pendukung_lain_tanggal1"] + "" != "" ? Convert.ToDateTime(Request.Form["dok_pendukung_lain_tanggal1"]) : null;
                                oObjectPerolehan1.AttribusiDokPendukungLainNama1 = Request.Form["attribusi_dok_pendukung_lain_nama1"] + "";
                                oObjectPerolehan1.AttribusiDokPendukungLainNomor2 = Request.Form["attribusi_dok_pendukung_lain_nomor2"] + "";
                                oObjectPerolehan1.AttribusiDokPendukungLainTanggal2 = Request.Form["attribusi_dok_pendukung_lain_tanggal2"] + "" != "" ? Convert.ToDateTime(Request.Form["attribusi_dok_pendukung_lain_tanggal2"]) : null;
                                oObjectPerolehan1.AttribusiDokPendukungLainNama2 = Request.Form["attribusi_dok_pendukung_lain_nama2"] + "";
                                oObjectPerolehan1.AttribusiDokPendukungLainNomor3 = Request.Form["attribusi_dok_pendukung_lain_nomor3"] + "";
                                oObjectPerolehan1.AttribusiDokPendukungLainTanggal3 = Request.Form["attribusi_dok_pendukung_lain_tanggal3"] + "" != "" ? Convert.ToDateTime(Request.Form["attribusi_dok_pendukung_lain_tanggal3"]) : null;
                                oObjectPerolehan1.AttribusiDokPendukungLainNama3 = Request.Form["attribusi_dok_pendukung_lain_nama3"] + "";
                                oObjectPerolehan1.NilaiPerolehanBarang = Request.Form["nilai_perolehan_barang"] + "" != "" ? Convert.ToDouble(Request.Form["nilai_perolehan_barang"] + "") : null;
                                oObjectPerolehan1.HargaSatuanPerolehan = Request.Form["harga_satuan_perolehan"] + "" != "" ? Convert.ToDouble(Request.Form["harga_satuan_perolehan"] + "") : null;
                                oObjectPerolehan1.DiinputolehNama = Request.Form["diinputoleh_nama"] + "";
                                oObjectPerolehan1.DiinputolehId = Request.Form["diinputoleh_id"] + "";
                                oObjectPerolehan1.DiinputolehTanggal = Request.Form["diinputoleh_tanggal"] + "" != "" ? Convert.ToDateTime(Request.Form["diinputoleh_tanggal"] + "") : null;
                            }
                        }
                        
                        db.SaveChanges();

                        transaction.Commit();
                        strResult = "success";
                    }
                    catch(Exception ee)
                    {
                        transaction.Rollback();
                        strResult= ee.Message;
                    }
                }
            }

        }catch(Exception ee)
        {
            strResult = ee.Message;
        }
        return Json(strResult);
    }

    [HttpPost]
    [Route("MesinPage/DeleteMesin")]
    public JsonResult DeleteMesin()
    {
        string strResult = "Error";
        try
        {
            using (EassetContext db = new EassetContext())
            {
                string strID = Request.Form["kib_b_id"] + "";
                TblKibB oObject = db.TblKibBs.Find(strID);
                if (oObject != null)
                {
                    oObject.OpEdit = "admin";
                    oObject.PcEdit = clsGlobal.GetIPAddr();
                    oObject.DateEdit = clsGlobal.getServerDate();
                    oObject.Dlt = 1;

                    db.SaveChanges();
                    strResult = "success";
                }
            }
        }
        catch (Exception ee)
        {
            strResult = ee.Message;
        }
        return Json(strResult);
    }
    [Route("MesinPage/KodeRekening")]
    public JsonResult GetKodeRekening()
    {
        string strSql = "select * from vwStrukRekening108";

        DataTable dtData = clsGlobal.getData(strSql);
        string strResult = clsGlobal.DataTableToJSON(dtData);
        return Json(new { data = strResult });
    }
}