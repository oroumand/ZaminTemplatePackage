using Microsoft.AspNetCore.Mvc;
using Zamin.Core.RequestResponse.Queries;
using Zamin.EndPoints.Web.Controllers;
using ZaminTemplate.Core.RequestResponse.FolderName.Commands.Create;
using ZaminTemplate.Core.RequestResponse.FolderName.Commands.Delete;
using ZaminTemplate.Core.RequestResponse.FolderName.Commands.Update;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetById;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetPagedFilter;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetSelectList;

namespace ZaminTemplate.Endpoints.API.FolderName;

[Route("api/[controller]")]

public sealed class AggregateNamesController : BaseController
{
    #region Commands
    [HttpPost("Create")]
    public async Task<IActionResult> CreateAggregateName(CreateAggregateNameCommand createAggregateName)
        => await Create<CreateAggregateNameCommand, int>(createAggregateName);

    [HttpPost("Update")]
    public async Task<IActionResult> CreateAggregateName(UpdateAggregateNameCommand updateAggregateName)
        => await Edit(updateAggregateName);

    [HttpDelete("Delete")]
    public async Task<IActionResult> DeleteAggregateName(DeleteAggregateNameCommand DeleteAggregateName)
        => await Delete(DeleteAggregateName);
    #endregion

    #region Queries
    [HttpGet("GetById")]
    public async Task<IActionResult> GetAggregateNameById([FromQuery] GetAggregateNameByIdQuery query)
        => await Query<GetAggregateNameByIdQuery, AggregateNameQr?>(query);

    [HttpGet("GetSelectList")]
    public async Task<IActionResult> GetAggregateNameSelectList([FromQuery] GetAggregateNameSelectListQuery query)
        => await Query<GetAggregateNameSelectListQuery, List<AggregateNameSelectItemQr>>(query);

    [HttpGet("GetPagedFilter")]
    public async Task<IActionResult> GetAggregateNamePagedFilter([FromQuery] GetAggregateNamePagedFilterQuery query)
        => await Query<GetAggregateNamePagedFilterQuery, PagedData<AggregateNameListItemQr>>(query);
    #endregion
}