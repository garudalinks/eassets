using EASSET.Helpers;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<EASSET.MasterData.UKPBRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = EASSET.MasterData.UKPBRow;

namespace EASSET.MasterData;

public interface IUKPBSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class UKPBSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IUKPBSaveHandler
{
    public UKPBSaveHandler(IRequestContext context)
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
            if(Row.SubUnitId == null)
            {
                Row.SubUnitId = "";
            }
            Row.Ukpbid = clsGlobal.getNewID();
            Row.ThAng = Convert.ToString(clsGlobal.getServerYear());
            Row.Op = UserName;
            Row.Lu = System.DateTime.Now;
            Row.Pc = HostNameAddr;
            Row.Dlt = 0;
        }
        else if (base.IsUpdate)

            if (Row.SubUnitId == null)
            {
                Row.SubUnitId = "";
            }
            Row.Op = UserName;
            Row.Lu = System.DateTime.Now;
            Row.Pc = HostNameAddr;
            Row.Dlt = 0;
    }
}