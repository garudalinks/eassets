using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<EASSET.MasterData.RuangRow>;
using MyRow = EASSET.MasterData.RuangRow;

namespace EASSET.MasterData;

public interface IRuangRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class RuangRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRuangRetrieveHandler
{
    public RuangRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}