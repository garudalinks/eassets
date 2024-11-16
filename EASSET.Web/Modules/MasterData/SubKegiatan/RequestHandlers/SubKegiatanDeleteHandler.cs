using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = EASSET.MasterData.SubKegiatanRow;

namespace EASSET.MasterData;

public interface ISubKegiatanDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SubKegiatanDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISubKegiatanDeleteHandler
{
    public SubKegiatanDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}