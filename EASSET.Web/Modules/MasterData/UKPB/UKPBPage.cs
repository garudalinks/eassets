using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace EASSET.MasterData.Pages;

[PageAuthorize(typeof(UKPBRow))]
public class UKPBPage : Controller
{
    [Route("MasterData/UKPB")]
    public ActionResult Index()
    {
        return this.GridPage("@/MasterData/UKPB/UKPBPage",
            UKPBRow.Fields.PageTitle());
    }
}