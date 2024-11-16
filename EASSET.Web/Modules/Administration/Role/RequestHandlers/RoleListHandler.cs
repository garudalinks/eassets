using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<EASSET.Administration.RoleRow>;
using MyRow = EASSET.Administration.RoleRow;


namespace EASSET.Administration;
public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RoleListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, MyRequest, MyResponse>(context), IRoleListHandler
{
}