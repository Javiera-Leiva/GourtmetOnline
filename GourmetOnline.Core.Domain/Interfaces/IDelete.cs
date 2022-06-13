using System;
using System.Collections.Generic;
using System.Text;

namespace GourmetOnline.Core.Domain.Interfaces
{
    public interface IDelete<EntityId>
    {
        void Delete(EntityId entityId);
    }
}
