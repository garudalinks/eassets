using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<EASSET.MasterData.SubUnitRow>;
using MyRow = EASSET.MasterData.SubUnitRow;

namespace EASSET.MasterData;

public interface ISubUnitListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SubUnitListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISubUnitListHandler
{
    public SubUnitListHandler(IRequestContext context)
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