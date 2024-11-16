using EASSET.Helpers;
using Microsoft.AspNetCore.Mvc;
using Serenity.Web;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using Dapper;

namespace EASSET.Perencanaan.Pages;

[PageAuthorize(typeof(RKBMDRow))]
public class RKBMDController1 : Controller
{
    private readonly ISqlConnections _sqlConnections;

    public RKBMDController1(ISqlConnections sqlConnections)
    {
        _sqlConnections = sqlConnections;
    }

    [Route("Perencanaan/RKBMD")]
    public ActionResult Index()
    {
        return this.GridPage("@/Perencanaan/RKBMD/RKBMDPage",
            RKBMDRow.Fields.PageTitle());
    }

    [Route("Perencanaan/RKBMD/KodeRekening")]
    public ActionResult KodeRekening()
    {
        string strSql = "select AkunKode+' '+AkunNama as AkunView,\nAkunKode+KelompokKode+' '+KelompokNama as KelompokView,\nAkunKode+KelompokKode+JenisKode+' '+JenisNama as JenisView,\nAkunKode+KelompokKode+JenisKode+ObjekKode+' '+ObjekNama as ObjekView,\nAkunKode+KelompokKode+JenisKode+ObjekKode+ROKode+' '+RONama as ROView,\nAkunKode+KelompokKode+JenisKode+ObjekKode+ROKode+SubROKode+' '+SubRONama as SubROView,\nAkunKode+KelompokKode+JenisKode+ObjekKode+ROKode+SubROKode+SubSubROKode+' '+SubSubRONama as SubSubROView,\nKodeRekening108, SubSubRO108ID\nfrom vwStrukRekening108\norder by SubSubROView";

        DataTable dtData = clsGlobal.getData(strSql);

        ViewBag.Data = dtData;

        return View("~/Modules/Perencanaan/RKBMD/KodeRekening.cshtml");
    }

    [Route("Perencanaan/RKBMD/GetDataKodeRekening")]
    public JsonResult GetDataKodeRekening()
    {
        string strSql = "select AkunKode+' '+AkunNama as AkunView,\nAkunKode+KelompokKode+' '+KelompokNama as KelompokView,\nAkunKode+KelompokKode+JenisKode+' '+JenisNama as JenisView,\nAkunKode+KelompokKode+JenisKode+ObjekKode+' '+ObjekNama as ObjekView,\nAkunKode+KelompokKode+JenisKode+ObjekKode+ROKode+' '+RONama as ROView,\nAkunKode+KelompokKode+JenisKode+ObjekKode+ROKode+SubROKode+' '+SubRONama as SubROView,\nAkunKode+KelompokKode+JenisKode+ObjekKode+ROKode+SubROKode+SubSubROKode+' '+SubSubRONama as SubSubROView,\nKodeRekening108, SubSubRO108ID\nfrom vwStrukRekening108\norder by SubSubROView";


        DataTable dtData = clsGlobal.getData(strSql);
        string strResult = clsGlobal.DataTableToJSON(dtData);
        return Json(new { data = strResult });
    }

    [Route("Perencanaan/RKBMD/AddRKBMD")]
    public ActionResult AddNewRkbmd()
    {
        return View("~/Modules/Perencanaan/RKBMD/FormRkbmd.cshtml");
    }

    [Route("Perencanaan/RKBMD/SaveRkbmd")]
    public JsonResult SaveRkbmd()
    {
        string strResult = "Error";
        try
        {
            using (var connection = _sqlConnections.NewByKey("Default"))
            {
                connection.Open();
                var RKBMD = new RKBMDRow
                {
                    Rkbmdid = clsGlobal.getNewID(),
                };

                var query = "INSERT INTO tbl_RKBMD (RKBMDID, KodeRekening, Jml_Usulan) VALUES (@RKBMDID, @KodeRekening, @Jml_Usulan)";
                connection.ExecuteAsync(query, new { RKBMD.Rkbmdid, RKBMD.KodeRekening });
            }

            strResult = "Success";
        }
        catch (Exception ee)
        {
            strResult = ee.Message;
        }
        
        //try
        //{
        //    using (SipantasContext db = new SipantasContext())
        //    {
        //        string strID = Request.Form["catin_id"] + "";
        //        MCatin oObject;

        //        if (string.IsNullOrEmpty(strID))
        //        {
        //            oObject = new MCatin();
        //            oObject.CatinId = ClsGlobal.getNewID();
        //            oObject.Dlt = 0;
        //            oObject.OpAdd = ClsGlobal.userName;
        //            oObject.PcAdd = ClsGlobal.GetUserIP();
        //            oObject.TglAdd = DateTime.Now;
        //            db.MCatins.Add(oObject);
        //        }
        //        else
        //        {
        //            oObject = db.MCatins.Find(strID);
        //            oObject.OpEdit = ClsGlobal.userName;
        //            oObject.PcEdit = ClsGlobal.GetUserIP();
        //            oObject.TglEdit = DateTime.Now;
        //        }
        //        if (oObject != null)
        //        {

        //            oObject.TimPendampingId = Request.Form["cboTimPendamping"] + "";
        //            oObject.Nik = Request.Form["txt_nik"] + "";
        //            oObject.Passwd = ClsGlobal.Encrypt(Request.Form["txt_password"] + "");
        //            oObject.NoHp = Request.Form["txt_nohp"] + "";
        //            oObject.WanitaNama = Request.Form["txt_nama_wanita"] + "";
        //            oObject.WanitaTempatLahir = Request.Form["txt_tempat_lahir_wanita"] + "";
        //            oObject.WanitaTglLahir = DateOnly.Parse(Request.Form["txt_tgl_lahir_wanita"]);
        //            oObject.WanitaAlamat = Request.Form["txt_alamat_wanita"] + "";
        //            oObject.PriaNik = Request.Form["txt_nik_pria"] + "";
        //            oObject.PriaNama = Request.Form["txt_nama_pria"] + "";
        //            oObject.PriaTempatLahir = Request.Form["txt_tempat_lahir_pria"] + "";
        //            oObject.PriaTglLahir = DateOnly.Parse(Request.Form["txt_tgl_lahir_pria"]);
        //            oObject.PriaAlamat = Request.Form["txt_alamat_pria"] + "";
        //            oObject.TglPerkiraan = DateOnly.Parse(Request.Form["txt_tgl_perkiraan"]);


        //            var files = Request.Form.Files;
        //            long size = files.Sum(f => f.Length);

        //            string strPathServer = Path.GetTempPath();

        //            var folderPath = Path.Combine(Environment.WebRootPath, "assets/Catin/Photos/" + oObject.CatinId + "/");

        //            foreach (var formFile in files)
        //            {
        //                if (formFile.Length > 0)
        //                {
        //                    if (formFile.Name == "txt_photo")
        //                    {
        //                        if (!Directory.Exists(folderPath))
        //                        {
        //                            Directory.CreateDirectory(folderPath);
        //                        }
        //                        string strExt = Path.GetExtension(formFile.FileName);
        //                        string strFileName = Request.Form["txt_nik"] + strExt;
        //                        var filePath = Path.Combine(folderPath, strFileName);
        //                        using (var stream = new FileStream(filePath, FileMode.Create))
        //                        {
        //                            formFile.CopyTo(stream);
        //                            oObject.Photo = strFileName;
        //                        }
        //                    }
        //                    if (formFile.Name == "txt_photo_pria")
        //                    {
        //                        if (!Directory.Exists(folderPath))
        //                        {
        //                            Directory.CreateDirectory(folderPath);
        //                        }
        //                        string strExt = Path.GetExtension(formFile.FileName);
        //                        string strFileName = Request.Form["txt_nik_pria"] + strExt;
        //                        var filePath = Path.Combine(folderPath, strFileName);
        //                        using (var stream = new FileStream(filePath, FileMode.Create))
        //                        {
        //                            formFile.CopyTo(stream);
        //                            oObject.PriaPhoto = strFileName;
        //                        }
        //                    }
        //                }
        //            }
        //            db.SaveChanges();
        //            strResult = "success";
        //        }
        //    }
        //}
        //catch (Exception ee)
        //{
        //    strResult = ee.Message;
        //}
        return Json(strResult);
    }

    //[Route("Perencanaan/Save/Rkbmd")]
    //[HttpPost]
    //public async Task<IActionResult> Save(RkbmdModel model)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        // Simpan data ke database menggunakan repository
    //        await _RkbmdRepository.SaveRkbmdAsync(model);

    //        return RedirectToAction("Index"); // Arahkan ke halaman yang diinginkan setelah simpan
    //    }
    //    return View("Index", model); // Jika ada kesalahan, kembali ke form
    //}
}