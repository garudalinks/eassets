using EASSET.Helpers;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<EASSET.MasterData.UPBRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = EASSET.MasterData.UPBRow;

namespace EASSET.MasterData;

public interface IUPBSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class UPBSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IUPBSaveHandler
{
    public UPBSaveHandler(IRequestContext context)
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
            Row.Upbid = clsGlobal.getNewID();
            Row.ThAng = Convert.ToString(clsGlobal.getServerYear());
            Row.Op = UserName;
            Row.Lu = System.DateTime.Now;
            Row.Pc = HostNameAddr;
            Row.Dlt = 0;
        }
        else if (base.IsUpdate)
        {
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

    protected override void BeforeSave()
    {
        base.BeforeSave();

        string selectedUpb = this.Row.Upbid;

        if (base.IsCreate)
        {
            
            if (!this.Connection.Exists<UPBRow>(MyRow.Fields.UpbNama == this.Row.UpbNama && MyRow.Fields.Dlt == 0))
            {
                // do anything you want to do
                //throw new ValidationError(Row.Name);
            }
            else
            {
                throw new ValidationError("Nama UPB ini sudah terdaftar");
            }
        }
        else if (base.IsUpdate)
        {
            if (!this.Connection.Exists<UPBRow>(MyRow.Fields.UpbNama == this.Row.UpbNama && MyRow.Fields.Dlt == 0 && MyRow.Fields.Upbid != selectedUpb))
            {
                // do anything you want to do
                //throw new ValidationError(Row.Name);
            }
            else
            {
                throw new ValidationError("Nama UPB ini sudah terdaftar");
            }
        }
    }
}