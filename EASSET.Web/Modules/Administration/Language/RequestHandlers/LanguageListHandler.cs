using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<EASSET.Administration.LanguageRow>;
using MyRow = EASSET.Administration.LanguageRow;


namespace EASSET.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, MyRequest, MyResponse>(context), ILanguageListHandler
{
}