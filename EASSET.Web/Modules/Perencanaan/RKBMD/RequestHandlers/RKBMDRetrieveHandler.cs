using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<EASSET.Perencanaan.RKBMDRow>;
using MyRow = EASSET.Perencanaan.RKBMDRow;

namespace EASSET.Perencanaan;

public interface IRKBMDRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class RKBMDRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRKBMDRetrieveHandler
{
    public RKBMDRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}