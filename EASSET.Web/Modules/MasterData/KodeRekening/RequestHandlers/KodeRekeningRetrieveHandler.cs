using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<EASSET.MasterData.KodeRekeningRow>;
using MyRow = EASSET.MasterData.KodeRekeningRow;

namespace EASSET.MasterData;

public interface IKodeRekeningRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class KodeRekeningRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IKodeRekeningRetrieveHandler
{
    public KodeRekeningRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}