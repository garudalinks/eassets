using EASSET.Helpers;
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = EASSET.Perencanaan.RKBMDRow;

namespace EASSET.Perencanaan;

public interface IRKBMDDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class RKBMDDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRKBMDDeleteHandler
{
    public RKBMDDeleteHandler(IRequestContext context)
            : base(context)
    {
    }

    protected override void ExecuteDelete()
    {
        String UserName = Context.User.Identity.Name;
        String HostNameAddr = clsGlobal.GetHostIPAddr();

        Connection.UpdateById(new MyRow { Dlt = 1, Op = UserName, Lu = clsGlobal.getServerDate(), Pc = HostNameAddr, Rkbmdid = this.Row.Rkbmdid });
    }
}