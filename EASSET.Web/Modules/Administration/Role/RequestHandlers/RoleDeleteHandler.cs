using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = EASSET.Administration.RoleRow;


namespace EASSET.Administration;
public interface IRoleDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }
public class RoleDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, MyRequest, MyResponse>(context), IRoleDeleteHandler
{
}