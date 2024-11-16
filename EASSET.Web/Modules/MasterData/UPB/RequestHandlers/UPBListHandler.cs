using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<EASSET.MasterData.UPBRow>;
using MyRow = EASSET.MasterData.UPBRow;

namespace EASSET.MasterData;

public interface IUPBListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UPBListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUPBListHandler
{
    public UPBListHandler(IRequestContext context)
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