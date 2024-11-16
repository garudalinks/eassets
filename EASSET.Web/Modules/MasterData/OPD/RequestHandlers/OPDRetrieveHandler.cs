using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<EASSET.MasterData.OPDRow>;
using MyRow = EASSET.MasterData.OPDRow;

namespace EASSET.MasterData;

public interface IOPDRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class OPDRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOPDRetrieveHandler
{
    public OPDRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}