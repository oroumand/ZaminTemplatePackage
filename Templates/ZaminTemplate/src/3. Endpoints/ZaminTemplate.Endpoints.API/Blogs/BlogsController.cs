using Microsoft.AspNetCore.Mvc;
using Zamin.EndPoints.Web.Controllers;
using ZaminTemplate.Core.Contracts.Blogs.Commands.CreateBlog;

namespace ZaminTemplate.Endpoints.API.Blogs;

[Route("api/[controller]")]
[ApiController]

public class BlogsController : BaseController
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateBlog(CreateBlogCommand createBlog) => await Create(createBlog);
}
