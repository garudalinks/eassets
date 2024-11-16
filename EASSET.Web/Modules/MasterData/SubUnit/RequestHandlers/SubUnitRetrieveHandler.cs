using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<EASSET.MasterData.SubUnitRow>;
using MyRow = EASSET.MasterData.SubUnitRow;

namespace EASSET.MasterData;

public interface ISubUnitRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SubUnitRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISubUnitRetrieveHandler
{
    public SubUnitRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}