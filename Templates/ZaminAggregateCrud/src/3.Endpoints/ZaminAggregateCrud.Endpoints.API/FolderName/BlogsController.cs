using Microsoft.AspNetCore.Mvc;
using Zamin.EndPoints.Web.Controllers;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Create;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Delete;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Update;

namespace ZaminAggregateCrud.Endpoints.API.Blogs;

[Route("api/[controller]")]
[ApiController]

public sealed class BlogsController : BaseController
{
    #region Commands

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateBlog(CreateBlogCommand createBlog) => await Create(createBlog);

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateBlog(UpdateBlogCommand updateBlog) => await Edit(updateBlog);

    [HttpDelete("[action]")]
    public async Task<IActionResult> DeleteBlog(DeleteBlogCommand DeleteBlog) => await Delete(DeleteBlog);
    #endregion
}
