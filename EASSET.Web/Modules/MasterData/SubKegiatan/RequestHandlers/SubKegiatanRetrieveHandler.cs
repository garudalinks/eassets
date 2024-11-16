using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<EASSET.MasterData.SubKegiatanRow>;
using MyRow = EASSET.MasterData.SubKegiatanRow;

namespace EASSET.MasterData;

public interface ISubKegiatanRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SubKegiatanRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISubKegiatanRetrieveHandler
{
    public SubKegiatanRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}