using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<EASSET.MasterData.KodeRekeningRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = EASSET.MasterData.KodeRekeningRow;

namespace EASSET.MasterData;

public interface IKodeRekeningSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class KodeRekeningSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IKodeRekeningSaveHandler
{
    public KodeRekeningSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}