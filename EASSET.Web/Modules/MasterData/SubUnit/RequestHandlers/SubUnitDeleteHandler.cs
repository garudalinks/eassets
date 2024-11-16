using EASSET.Helpers;
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = EASSET.MasterData.SubUnitRow;

namespace EASSET.MasterData;

public interface ISubUnitDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SubUnitDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISubUnitDeleteHandler
{
    public SubUnitDeleteHandler(IRequestContext context)
            : base(context)
    {
    }

    protected override void ExecuteDelete()
    {
        String UserName = Context.User.Identity.Name;
        String HostNameAddr = clsGlobal.GetHostIPAddr();

        Connection.UpdateById(new MyRow { Dlt = true, Op = UserName, Lu = clsGlobal.getServerDate(), Pc = HostNameAddr, SubUnitId = this.Row.SubUnitId });
    }
}