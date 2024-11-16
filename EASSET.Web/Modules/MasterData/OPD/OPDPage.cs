using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace EASSET.MasterData.Pages;

[PageAuthorize(typeof(OPDRow))]
public class OPDPage : Controller
{
    [Route("MasterData/OPD")]
    public ActionResult Index()
    {
        return this.GridPage("@/MasterData/OPD/OPDPage",
            OPDRow.Fields.PageTitle());
    }
}