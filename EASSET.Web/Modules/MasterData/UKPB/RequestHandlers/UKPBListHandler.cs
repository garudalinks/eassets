using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<EASSET.MasterData.UKPBRow>;
using MyRow = EASSET.MasterData.UKPBRow;

namespace EASSET.MasterData;

public interface IUKPBListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UKPBListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUKPBListHandler
{
    public UKPBListHandler(IRequestContext context)
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