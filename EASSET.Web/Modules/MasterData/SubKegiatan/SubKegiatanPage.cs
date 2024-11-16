using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace EASSET.MasterData.Pages;

[PageAuthorize(typeof(SubKegiatanRow))]
public class SubKegiatanPage : Controller
{
    [Route("MasterData/SubKegiatan")]
    public ActionResult Index()
    {
        return this.GridPage("@/MasterData/SubKegiatan/SubKegiatanPage",
            SubKegiatanRow.Fields.PageTitle());
    }
}