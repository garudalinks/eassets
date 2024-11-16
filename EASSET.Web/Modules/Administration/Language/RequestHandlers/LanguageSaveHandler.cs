using MyRequest = Serenity.Services.SaveRequest<EASSET.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = EASSET.Administration.LanguageRow;

namespace EASSET.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, MyRequest, MyResponse>(context), ILanguageSaveHandler
{
}