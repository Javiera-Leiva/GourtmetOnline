using System;
using System.Collections.Generic;
using System.Text;
using GourmetOnline.Core.Domain.Interfaces;


namespace GourmetOnline.Core.Infraestructure.Repository.Abstract
{
    public interface IBaseRepository<Entity, EntityId> : ICreate<Entity>,
       IRead<Entity, EntityId>, IUpdate<Entity>, IDelete<EntityId>, ITransaction
    {
      
    }
}
