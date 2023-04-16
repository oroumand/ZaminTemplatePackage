using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Core.Domain.ValueObjects;
using ZaminAggregateCrud.Core.Domain.FolderName.Events;
using ZaminAggregateCrud.Core.Domain.FolderName.Parameters;

namespace ZaminAggregateCrud.Core.Domain.FolderName.Entities
{
    public sealed class Blog : AggregateRoot
    {
        #region Properties

        #endregion

        #region Constructors
        private Blog()
        {

        }
        public Blog(BusinessId businessId)
        {
            BusinessId = businessId;
            AddEvent(new BlogCreated(BusinessId.Value));
        }
        #endregion

        #region Commands
        public void Update(BlogUpdateParameter parameter)
        {
            AddEvent(new BlogUpdated(BusinessId.Value));
        }

        public void Delete()
        {
            AddEvent(new BlogDeleted(BusinessId.Value));
        }
        #endregion

    }
}
