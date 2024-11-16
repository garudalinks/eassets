using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = EASSET.MasterData.KodeRekeningRow;

namespace EASSET.MasterData;

public interface IKodeRekeningDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class KodeRekeningDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IKodeRekeningDeleteHandler
{
    public KodeRekeningDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}