using System;
using System.Collections.Generic;
using System.Text;

using GourmetOnline.Core.Domain.Interfaces;

namespace GourmetOnline.Core.Infraestructure.Repository.Abstract
{
    public interface IDetailRepository<Entity, TransactionId> : ICreate<Entity>, ITransaction
    {
        List<Entity> GetDetailsByTransaction(TransactionId transactionId);
    }
}
