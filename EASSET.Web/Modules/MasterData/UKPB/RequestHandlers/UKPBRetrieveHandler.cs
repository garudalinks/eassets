using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<EASSET.MasterData.UKPBRow>;
using MyRow = EASSET.MasterData.UKPBRow;

namespace EASSET.MasterData;

public interface IUKPBRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class UKPBRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUKPBRetrieveHandler
{
    public UKPBRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}