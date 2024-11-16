using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<EASSET.MasterData.UPBRow>;
using MyRow = EASSET.MasterData.UPBRow;

namespace EASSET.MasterData;

public interface IUPBRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class UPBRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUPBRetrieveHandler
{
    public UPBRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }

}