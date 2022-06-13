using System;
using System.Collections.Generic;
using System.Text;
using GourmetOnline.Core.Domain.Interfaces;


namespace GourmetOnline.Core.Aplication.Interfaces
{
    public interface IBaseUseCase<Entity, EntityId> : ICreate<Entity>,  
        IRead<Entity, EntityId>,  IUpdate<Entity>, IDelete<EntityId>
    {

    }
}
