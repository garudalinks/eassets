using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<EASSET.MasterData.SubKegiatanRow>;
using MyRow = EASSET.MasterData.SubKegiatanRow;

namespace EASSET.MasterData;

public interface ISubKegiatanListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SubKegiatanListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISubKegiatanListHandler
{
    public SubKegiatanListHandler(IRequestContext context)
            : base(context)
    {
    }
}