using EASSET.Models;
using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace EASSET.Monitoring.Pages;
public class MonitoringPage1 : Controller
{
    [Route("/Monitoring")]
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [Route("/Monitoring/SaveGpsLoc")]
    public JsonResult SaveGPSLoc()
    {
        string strResult = "Error";

        try
        {
            using (EassetContext db = new EassetContext())
            {
                string strID = Request.Form["catin_id"] + "";
                TblLoggpsTrack oObject = new TblLoggpsTrack();

                //oObject.LoggpsTrackid = ClsGlobal.getNewID();
                oObject.Nohp = "";
                oObject.Lat = "";
                oObject.Lon = "";
                oObject.SpeedKmH = 0;
                oObject.Tanggal = DateTime.Now;
                db.TblLoggpsTracks.Add(oObject);

                db.SaveChanges();
                strResult = "success";

            }
        }
        catch (Exception ee)
        {
            strResult = ee.Message;
        }

        return Json(strResult);
    }
}