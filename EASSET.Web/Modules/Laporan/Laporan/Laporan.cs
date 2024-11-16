using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace EASSET.Laporan.Pages;
public class Laporan : Controller
{
    [Route("Laporan/Perolehan&Penerimaan")]
    public ActionResult Index()
    {
       return View();
    }
}