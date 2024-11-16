using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace EASSET.MasterData.Pages;

[PageAuthorize(typeof(KodeRekeningRow))]
public class KodeRekeningPage : Controller
{
    [Route("MasterData/KodeRekening")]
    public ActionResult Index()
    {
        return this.GridPage("@/MasterData/KodeRekening/KodeRekeningPage",
            KodeRekeningRow.Fields.PageTitle());
    }
}