using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<EASSET.MasterData.OPDRow>;
using MyRow = EASSET.MasterData.OPDRow;

namespace EASSET.MasterData;

public interface IOPDListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class OPDListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IOPDListHandler
{
    public OPDListHandler(IRequestContext context)
            : base(context)
    {
    }

    protected override void ApplyFilters(SqlQuery query)
    {
        base.ApplyFilters(query);
        // Ignore inactive records
        query.Where(new Criteria("T0.DLT") == 0);
    }
}