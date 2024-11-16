using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<EASSET.Administration.LanguageRow>;
using MyRow = EASSET.Administration.LanguageRow;


namespace EASSET.Administration;
public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, MyRequest, MyResponse>(context), ILanguageRetrieveHandler
{
}