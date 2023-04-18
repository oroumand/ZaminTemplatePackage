using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.EndPoints.Web.Controllers;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Create;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Delete;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands.Update;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetAll;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetDetail;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetPagedFilter;

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


    #region Queries
    [HttpGet("[action]")]
    public async Task<IActionResult> GetBlogById([FromQuery] GetBlogByIdQuery query)
        => await Query<GetBlogByIdQuery, BlogDetailQr>(query);

    [HttpGet("[action]")]
    public async Task<IActionResult> GetBlogsGetPagedFilter([FromQuery] GetBlogPagedQuery query)
        => await Query<GetBlogPagedQuery, PagedData<BlogListItemQr>>(query);

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllBlogs([FromQuery] GetAllBlogQuery query)
        => await Query<GetAllBlogQuery, List<BlogListItemQr>>(query);



    #endregion
}
