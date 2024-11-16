using EASSET.Helpers;
using Serenity.Services;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = EASSET.MasterData.UPBRow;

namespace EASSET.MasterData;

public interface IUPBDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class UPBDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IUPBDeleteHandler
{
    public UPBDeleteHandler(IRequestContext context)
            : base(context)
    {
    }

    //protected override void ValidateRequest()
    //{
    //    base.ValidateRequest();
    //    DataTable dtData = clsGlobal.getData("select * from tbmUPB");
    //    throw new Exception("You must login user \"hm\" for delete row!");
    //}
    //protected override void OnBeforeDelete()
    //{
    //    base.OnBeforeDelete();

    //    int selectedKecamatan = Convert.ToInt32(this.Row.Upbid);


    //    if (this.Connection.Exists<OPDRow>(MyRow.Fields.KecamatanId == selectedKecamatan))
    //    {
    //        throw new ValidationError("Data tidak bisa dihapus karena telah menjadi acuan data Organisasi");
    //    }
    //}

    protected override void ExecuteDelete()
    {
        String UserName = Context.User.Identity.Name;
        String HostNameAddr = clsGlobal.GetHostIPAddr();

        Connection.UpdateById(new MyRow { Dlt = 1, Op = UserName, Lu = System.DateTime.Now, Pc = HostNameAddr, Upbid = this.Row.Upbid });
    }
}