using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<EASSET.Administration.RoleRow>;
using MyRow = EASSET.Administration.RoleRow;


namespace EASSET.Administration;
public interface IRoleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class RoleRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, MyRequest, MyResponse>(context), IRoleRetrieveHandler
{
}