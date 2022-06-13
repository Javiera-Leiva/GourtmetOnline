﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GourmetOnline.Core.Domain.Interfaces
{
    public interface IRead<Entity, EntityId>
    {
        Entity GetById(EntityId entityId);

        List<Entity> GetAll();
    }
}
