using EASSET.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serenity.Web;
using System.Data;
using System.IO;
using EASSET.Models;
using Microsoft.AspNetCore.Hosting;

namespace EASSET.Penatausahaan.Pages;

public class TanahPage : Controller
{
    private IWebHostEnvironment Environment;
    public TanahPage(IWebHostEnvironment _environment)
    {
        Environment = _environment;
    }


    [Route("Penatausahaan/Tanah")]
    public ActionResult Index()
    {
        string strSql = "select UnitID, UnitNama, Alamat from tbmUnit where DLT='0' ORDER BY UnitNama";
        string strSqlKecamatan = "select a.kecamatan_id, a.kode, a.nama\r\nfrom INFIS_TPP_2020.dbo.m_kecamatan a\r\nwhere a.dlt='0'\r\norder by a.kode";
        string strSqlKelurahan = "select a.kecamatan_id, a.kode as kecamatan_kode, a.nama as kecamatan_nama, b.kelurahan_id, b.kode, b.nama\r\nfrom INFIS_TPP_2020.dbo.m_kecamatan a\r\ninner join INFIS_TPP_2020.dbo.m_kelurahan b on a.kecamatan_id=b.kecamatan_id and b.dlt='0'\r\nwhere a.dlt='0'\r\norder by a.kode, b.kode;\r\n";

        DataTable dtUnit = clsGlobal.getData(strSql);
        DataTable dtKecamatan = clsGlobal.getData(strSqlKecamatan);
        DataTable dtKelurahan = clsGlobal.getData(strSqlKelurahan);

        ViewBag.dtUnit = dtUnit;
        ViewBag.dtKec = dtKecamatan;
        ViewBag.dtKel = dtKelurahan;

        return View();
    }
    [Route("Tanah/GetDataAset")]
    public JsonResult Get()
    {
        string strSql = "select kib_a_id,jenis_pengguna_barang,barang_nama_barang from tbl_kib_a where dlt='0'";

        DataTable dtData = clsGlobal.getData(strSql);
        string strResult = clsGlobal.DataTableToJSON(dtData);
        return Json(strResult);
    }
    [Route("TanahPage/GetKelurahan")]
    public JsonResult GetKelurahan()
    {
        string strSql = "select a.kecamatan_id, a.kode as kecamatan_kode, a.nama as kecamatan_nama, b.kelurahan_id, b.kode, b.nama, b.kelurahan_id+'_'+b.nama as kel_nama from INFIS_TPP_2020.dbo.m_kecamatan a inner join INFIS_TPP_2020.dbo.m_kelurahan b on a.kecamatan_id=b.kecamatan_id and b.dlt='0'where a.dlt='0'order by a.kode, b.kode\r\n";
        DataTable dtData = clsGlobal.getData(strSql);
        string strResult = clsGlobal.DataTableToJSON(dtData);
        return Json(new { data = strResult });
    }

    [HttpPost]
    [Route("TanahPage/SaveTanah")]
    public JsonResult SaveTanah(string lokNama)
    {
        string strResult = "Error";
        try
        {
            using(EassetContext db = new EassetContext())
            {
                string strID = Request.Form["kib_a_id"] + "";
                string strKec = Request.Form["barang_lok_kecamatan_id"] + "";
                string strKel = Request.Form["barang_lok_kelurahan_desa_id"] + "";

                string strKecId = "";
                string strKecNama = "";
                string strKelId = "";
                string strKelNama = "";

                if (strKec != "")
                {
                    string[] splitKec = strKec.Split("-");
                    strKecId = splitKec[0];
                    strKecNama = splitKec[1];

                }
                if (strKel != "")
                {
                    string[] splitKel = strKel.Split("_");
                    strKelId = splitKel[0];
                    strKelNama = splitKel[1];
                }

                TblKibA oObject;

                if (string.IsNullOrEmpty(strID))
                {
                    oObject = new TblKibA();
                    oObject.KibAId = clsGlobal.getNewID();
                    oObject.Dlt = 0;
                    oObject.OpAdd = "admin";
                    oObject.PcAdd = clsGlobal.GetIPAddr();
                    oObject.DateAdd = clsGlobal.getServerDate();
                    db.TblKibAs.Add(oObject);
                }
                else
                {
                    oObject = db.TblKibAs.Find(strID);
                    oObject.OpEdit = "admin";
                    oObject.PcEdit = clsGlobal.GetIPAddr();
                    oObject.DateEdit = clsGlobal.getServerDate();
                    db.TblKibAs.Add(oObject);

                }

                if(oObject != null)
                {
                    oObject.UnitId = Request.Form["UnitID"] + "";
                    oObject.JenisPenggunaBarang = Request.Form["jenis_pengguna_barang"] + "";
                    oObject.UnitPenggunaBarangId = Request.Form["unit_pengguna_barang_id"] + "";
                    oObject.Tahun = Request.Form["tahun"] + "";
                    oObject.UnitAlamat = Request.Form["unit_alamat"] + "";
                    oObject.BarangKodeBarang = Request.Form["barang_kode_barang"] + "";
                    oObject.BarangKodeLokasi = Request.Form["barang_kode_lokasi"] + "";
                    oObject.BarangKodeRegBarang = Request.Form["barang_kode_reg_barang"] + "";
                    oObject.BarangNibar = clsGlobal.getNewID();
                    oObject.BarangNamaBarang = Request.Form["barang_nama_barang"] + "";
                    oObject.BarangSpesifikasi = Request.Form["barang_spesifikasi"] + "";
                    oObject.BarangLuasTanah = Request.Form["barang_luas_tanah"] + "" != "" ? Convert.ToDouble(Request.Form["barang_luas_tanah"] + "") : null;
                    oObject.BarangSatuan = Request.Form["barang_satuan"] + "";
                    oObject.BarangKondisiBarang = Request.Form["barang_kondisi_barang"] + "";
                    oObject.BarangLokProvinsi = "Kepulauan Riau";
                    oObject.BarangLokKabKota = "Natuna";
                    oObject.BarangLokKecamatanId = strKecId;
                    oObject.BarangLokKecamatanNama = strKecNama;
                    oObject.BarangLokKelurahanDesaId = strKelId;
                    oObject.BarangLokKelurahanDesaNama = strKelNama;
                    oObject.BarangLokJalan = Request.Form["barang_lok_jalan"] + "";
                    oObject.BarangLokRtRw = Request.Form["barang_lok_rt_rw"] + "";
                    oObject.BarangLokKoordinat = Request.Form["barang_lok_koordinat"] + "";
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
                    oObject.BarangDokNamaDok = Request.Form["barang_dok_nama_dok"] + "";
                    oObject.BarangDokTanggal = Request.Form["barang_dok_tanggal"] + "" != "" ? Convert.ToDateTime(Request.Form["barang_dok_tanggal"] + "") : null;
                    oObject.BarangDokNomor = Request.Form["barang_dok_nomor"] + "";
                    oObject.BarangDokNamaKepemilikan = Request.Form["barang_dok_nama_kepemilikan"] + "";
                    oObject.BarangBatasUtara = Request.Form["barang_batas_utara"] + "";
                    oObject.BarangBatasTimur = Request.Form["barang_batas_timur"] + "";
                    oObject.BarangBatasSelatan = Request.Form["barang_batas_selatan"] + "";
                    oObject.BarangBatasBarat = Request.Form["barang_batas_barat"] + "";
                    oObject.BarangCaraperolehan = Request.Form["barang_caraperolehan"] + "";
                    oObject.BarangKeterangan = Request.Form["barang_keterangan"] + "";
                    oObject.BarangDiinputolehNama = Request.Form["barang_diinputoleh_nama"] + "";
                    oObject.BarangDiinputolehId = Request.Form["barang_diinputoleh_id"] + "";
                    oObject.BarangTanggalInput = Request.Form["barang_tanggal_input"] + ""  != "" ? Convert.ToDateTime(Request.Form["barang_tanggal_input"] + "") : null;
                    oObject.BarangTanggalPerolehan = Request.Form["barang_tanggal_perolehan"] + "" != "" ? Convert.ToDateTime(Request.Form["barang_tanggal_perolehan"] + "") : null;


                    var files = Request.Form.Files;
                    long size = files.Sum(f => f.Length);

                    string strPathServer = Path.GetTempPath();

                    var folderPath = Path.Combine(Environment.WebRootPath, "assets/Tanah/Photos/" + oObject.KibAId + "/");

                    foreach (var formFile in files)
                    {
                        if (formFile.Length > 0)
                        {
                            if (formFile.Name == "barang_fotodenah_file")
                            {
                                if (!Directory.Exists(folderPath))
                                {
                                    Directory.CreateDirectory(folderPath);
                                }
                                string strExt = Path.GetExtension(formFile.FileName);
                                string strFileName = oObject.KibAId + strExt;
                                var filePath = Path.Combine(folderPath, strFileName);
                                using (var stream = new FileStream(filePath, FileMode.Create))
                                {
                                    formFile.CopyTo(stream);
                                    oObject.BarangFotodenahFile = strFileName;
                                }
                            }
                        }
                    }
                    db.SaveChanges();
                    strResult = "success";
                }
            }

        }catch(Exception ee)
        {
            strResult = ee.Message;
        }
        return Json(strResult);
    }
}