using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<EASSET.MasterData.RuangRow>;
using MyRow = EASSET.MasterData.RuangRow;

namespace EASSET.MasterData;

public interface IRuangListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RuangListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRuangListHandler
{
    public RuangListHandler(IRequestContext context)
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