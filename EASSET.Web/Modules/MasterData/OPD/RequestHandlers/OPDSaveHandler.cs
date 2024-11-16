using EASSET.Helpers;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<EASSET.MasterData.OPDRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = EASSET.MasterData.OPDRow;

namespace EASSET.MasterData;

public interface IOPDSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class OPDSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IOPDSaveHandler
{
    public OPDSaveHandler(IRequestContext context)
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
            Row.UnitId = clsGlobal.getNewID();
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