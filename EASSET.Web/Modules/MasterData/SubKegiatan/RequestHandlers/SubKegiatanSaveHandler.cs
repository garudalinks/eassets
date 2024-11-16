using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<EASSET.MasterData.SubKegiatanRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = EASSET.MasterData.SubKegiatanRow;

namespace EASSET.MasterData;

public interface ISubKegiatanSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SubKegiatanSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISubKegiatanSaveHandler
{
    public SubKegiatanSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}