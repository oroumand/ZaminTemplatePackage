using Zamin.Core.Domain.Entities;
using ZaminTemplate.Core.Domain.FolderName.Events;
using ZaminTemplate.Core.Domain.FolderName.Parameters;

namespace ZaminTemplate.Core.Domain.FolderName.Entities;

public sealed class AggregateName : AggregateRoot<int>
{
    #region Properties

    #endregion

    #region Constructors
    private AggregateName()
    {

    }
    public AggregateName(AggregateNameCreateParameter parameter)
    {
        BusinessId = parameter.BusinessId;
        AddEvent(new AggregateNameCreated(BusinessId.Value));
    }
    #endregion

    #region Commands
    public void Update(AggregateNameUpdateParameter parameter)
    {
        AddEvent(new AggregateNameUpdated(BusinessId.Value));
    }

    public void Delete()
    {
        AddEvent(new AggregateNameDeleted(BusinessId.Value));
    }
    #endregion
}