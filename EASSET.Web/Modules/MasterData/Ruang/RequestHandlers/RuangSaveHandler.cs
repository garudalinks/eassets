using EASSET.Helpers;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<EASSET.MasterData.RuangRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = EASSET.MasterData.RuangRow;

namespace EASSET.MasterData;

public interface IRuangSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class RuangSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRuangSaveHandler
{
    public RuangSaveHandler(IRequestContext context)
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
            if (Row.SubUnitId == null)
            {
                Row.SubUnitId = "";
            }
            Row.RuangId = clsGlobal.getNewID();
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

    //protected override void BeforeSave()
    //{
    //    base.BeforeSave();

    //    string selectedUpb = this.Row.RuangId;

    //    if (base.IsCreate)
    //    {

    //        if (!this.Connection.Exists<UPBRow>(MyRow.Fields.RuangNama == this.Row.RuangNama && MyRow.Fields.Dlt == 0))
    //        {
    //            // do anything you want to do
    //            //throw new ValidationError(Row.Name);
    //        }
    //        else
    //        {
    //            throw new ValidationError("Nama Ruang ini sudah terdaftar");
    //        }
    //    }
    //    else if (base.IsUpdate)
    //    {
    //        if (!this.Connection.Exists<UPBRow>(MyRow.Fields.RuangNama == this.Row.RuangNama && MyRow.Fields.Dlt == 0 && MyRow.Fields.RuangId != selectedUpb))
    //        {
    //            // do anything you want to do
    //            //throw new ValidationError(Row.Name);
    //        }
    //        else
    //        {
    //            throw new ValidationError("Nama Ruang ini sudah terdaftar");
    //        }
    //    }
    //}
}