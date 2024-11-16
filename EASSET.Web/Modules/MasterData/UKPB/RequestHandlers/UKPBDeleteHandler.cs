using EASSET.Helpers;
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = EASSET.MasterData.UKPBRow;

namespace EASSET.MasterData;

public interface IUKPBDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class UKPBDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IUKPBDeleteHandler
{
    public UKPBDeleteHandler(IRequestContext context)
            : base(context)
    {
    }

    protected override void ExecuteDelete()
    {
        String UserName = Context.User.Identity.Name;
        String HostNameAddr = clsGlobal.GetHostIPAddr();

        Connection.UpdateById(new MyRow { Dlt = 1, Op = UserName, Lu = System.DateTime.Now, Pc = HostNameAddr, Ukpbid = this.Row.Ukpbid });
    }
}