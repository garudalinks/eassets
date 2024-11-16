using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<EASSET.Administration.UserRow>;
using MyRow = EASSET.Administration.UserRow;


namespace EASSET.Administration;
public interface IUserRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class UserRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, MyRequest, MyResponse>(context), IUserRetrieveHandler
{
}