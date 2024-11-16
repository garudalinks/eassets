using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace EASSET.MasterData.Pages;

[PageAuthorize(typeof(UPBRow))]
public class MonitoringPage : Controller
{
    [Route("MasterData/UPB")]
    public ActionResult Index()
    {
        return this.GridPage("@/MasterData/UPB/UPBPage",
            UPBRow.Fields.PageTitle());
    }
}