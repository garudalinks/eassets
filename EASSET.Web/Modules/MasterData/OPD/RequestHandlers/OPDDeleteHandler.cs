using EASSET.Helpers;
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = EASSET.MasterData.OPDRow;

namespace EASSET.MasterData;

public interface IOPDDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class OPDDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IOPDDeleteHandler
{
    public OPDDeleteHandler(IRequestContext context)
            : base(context)
    {
    }

    protected override void ExecuteDelete()
    {
        String UserName = Context.User.Identity.Name;
        String HostNameAddr = clsGlobal.GetHostIPAddr();

        Connection.UpdateById(new MyRow { Dlt = true, Op = UserName, Lu = clsGlobal.getServerDate(), Pc = HostNameAddr, UnitId = this.Row.UnitId });
    }
}