using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace EASSET.MasterData.Pages;

[PageAuthorize(typeof(SubUnitRow))]
public class SubUnitPage : Controller
{
    [Route("MasterData/SubUnit")]
    public ActionResult Index()
    {
        return this.GridPage("@/MasterData/SubUnit/SubUnitPage",
            SubUnitRow.Fields.PageTitle());
    }
}