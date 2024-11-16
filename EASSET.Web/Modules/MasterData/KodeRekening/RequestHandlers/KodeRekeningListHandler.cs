using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<EASSET.MasterData.KodeRekeningRow>;
using MyRow = EASSET.MasterData.KodeRekeningRow;

namespace EASSET.MasterData;

public interface IKodeRekeningListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class KodeRekeningListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IKodeRekeningListHandler
{
    public KodeRekeningListHandler(IRequestContext context)
            : base(context)
    {
    }
}