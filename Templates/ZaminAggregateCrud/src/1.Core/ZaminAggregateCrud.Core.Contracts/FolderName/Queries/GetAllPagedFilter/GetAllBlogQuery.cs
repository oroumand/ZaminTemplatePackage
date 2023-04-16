using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;
using ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetAll;

namespace ZaminAggregateCrud.Core.Contracts.FolderName.Queries.GetAllPagedFilter
{
    public sealed class GetAllBlogPagedQuery: PageQuery<PagedData<GetAllBlogListItemQr>>
    {
    }
}
