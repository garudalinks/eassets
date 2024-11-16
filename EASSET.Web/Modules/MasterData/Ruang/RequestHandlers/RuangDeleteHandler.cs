using EASSET.Helpers;
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = EASSET.MasterData.RuangRow;

namespace EASSET.MasterData;

public interface IRuangDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class RuangDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRuangDeleteHandler
{
    public RuangDeleteHandler(IRequestContext context)
            : base(context)
    {
    }

    protected override void ExecuteDelete()
    {
        String UserName = Context.User.Identity.Name;
        String HostNameAddr = clsGlobal.GetHostIPAddr();

        Connection.UpdateById(new MyRow { Dlt = 1, Op = UserName, Lu = System.DateTime.Now, Pc = HostNameAddr, RuangId = this.Row.RuangId });
    }
}