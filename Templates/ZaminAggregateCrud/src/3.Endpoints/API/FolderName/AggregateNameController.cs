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

public sealed class AggregateNameController : BaseController
{
    #region Commands
    [HttpPost("Create")]
    public async Task<IActionResult> CreateAggregateName([FromBody] AggregateNameCreateCommand command)
        => await Create<AggregateNameCreateCommand, int>(command);

    [HttpPut("Update")]
    public async Task<IActionResult> UpdateAggregateName([FromBody] AggregateNameUpdateCommand command)
        => await Edit(command);

    [HttpDelete("Delete")]
    public async Task<IActionResult> DeleteAggregateName([FromBody] AggregateNameDeleteCommand command)
        => await Delete(command);
    #endregion

    #region Queries
    [HttpGet("GetById")]
    public async Task<IActionResult> GetAggregateNameById([FromQuery] AggregateNameGetByIdQuery query)
        => await Query<AggregateNameGetByIdQuery, AggregateNameQr?>(query);

    [HttpGet("GetSelectList")]
    public async Task<IActionResult> GetAggregateNameSelectList([FromQuery] AggregateNameGetSelectListQuery query)
        => await Query<AggregateNameGetSelectListQuery, List<AggregateNameSelectItemQr>>(query);

    [HttpGet("GetPagedFilter")]
    public async Task<IActionResult> GetAggregateNamePagedFilter([FromQuery] AggregateNameGetPagedFilterQuery query)
        => await Query<AggregateNameGetPagedFilterQuery, PagedData<AggregateNameListItemQr>>(query);
    #endregion
}