using ZaminTemplate.Core.Domain.Blogs.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Core.Domain.ValueObjects;

namespace ZaminTemplate.Core.Domain.Blogs.Entities
{
    public class Blog:AggregateRoot
    {
        #region Properties
        public Title Title { get; private set; }
        public Description Description { get; private set; }
        #endregion

        #region Constructors
        private Blog()
        {

        }
        public Blog(BusinessId businessId, Title title, Description description)
        {
            BusinessId = businessId;
            Title = title;
            Description = description;
            AddEvent(new BlogCreated(businessId.Value.ToString(), Title.Value, Description.Value));
        } 
        #endregion

    }
}
