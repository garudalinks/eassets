using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = EASSET.Administration.LanguageRow;


namespace EASSET.Administration;
public interface ILanguageDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, MyRequest, MyResponse>(context), ILanguageDeleteHandler
{
}