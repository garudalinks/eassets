using EASSET.Helpers;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<EASSET.MasterData.SubUnitRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = EASSET.MasterData.SubUnitRow;

namespace EASSET.MasterData;

public interface ISubUnitSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SubUnitSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISubUnitSaveHandler
{
    public SubUnitSaveHandler(IRequestContext context)
            : base(context)
    {
    }

    protected override void SetInternalFields()
    {
        base.SetInternalFields();

        String UserName = Context.User.Identity.Name;
        String HostNameAddr = clsGlobal.GetHostIPAddr();

        if (base.IsCreate)
        {
            Row.SubUnitId = clsGlobal.getNewID();
            Row.ThAng = Convert.ToString(clsGlobal.getServerYear());
            Row.Op = UserName;
            Row.Lu = clsGlobal.getServerDate();
            Row.Pc = HostNameAddr;
            Row.Dlt = false;
        }
        else if (base.IsUpdate)
        {
            Row.Op = UserName;
            Row.Lu = clsGlobal.getServerDate();
            Row.Pc = HostNameAddr;
            Row.Dlt = false;
        }
    }
}