using Serenity.Services;
using EASSET.Helpers;
using MyRequest = Serenity.Services.SaveRequest<EASSET.Perencanaan.RKBMDRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = EASSET.Perencanaan.RKBMDRow;
using System.Data;

namespace EASSET.Perencanaan;

public interface IRKBMDSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class RKBMDSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRKBMDSaveHandler
{
    public RKBMDSaveHandler(IRequestContext context)
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
            Row.Rkbmdid = clsGlobal.getNewID();
            Row.ThAng = Convert.ToString(clsGlobal.getServerYear());
            Row.Op = UserName;
            Row.Lu = clsGlobal.getServerDate();
            Row.Pc = HostNameAddr;
            Row.Dlt = 0;
        }
        else if (base.IsUpdate)
        {
            if (Row.Rkbmdid == null)
            {
                Row.Rkbmdid = "";
            }
            Row.Op = UserName;
            Row.Lu = clsGlobal.getServerDate();
            Row.Pc = HostNameAddr;
            Row.Dlt = 0;

        }
    }
    protected override void BeforeSave()
    {
        base.BeforeSave();

        // Mendapatkan nomor urut terakhir
        string sql = "SELECT MAX(NoUrut) FROM tbl_RKBMD WHERE DLT ='0'";
        if(Row.NoUrut == null)
        {
            string lastOrder = clsGlobal.getData1Field(sql);

            int noUrut1 = lastOrder == "" ? 1 : int.Parse(lastOrder) + 1;

            Row.NoUrut = noUrut1;
        }
    }
}