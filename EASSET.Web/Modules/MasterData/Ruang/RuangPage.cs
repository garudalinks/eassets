using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace EASSET.MasterData.Pages;

[PageAuthorize(typeof(RuangRow))]
public class RuangPage : Controller
{
    [Route("MasterData/Ruang")]
    public ActionResult Index()
    {
        return this.GridPage("@/MasterData/Ruang/RuangPage",
            RuangRow.Fields.PageTitle());
    }
}