using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<EASSET.Perencanaan.RKBMDRow>;
using MyRow = EASSET.Perencanaan.RKBMDRow;

namespace EASSET.Perencanaan;

public interface IRKBMDListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RKBMDListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRKBMDListHandler
{
    public RKBMDListHandler(IRequestContext context)
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