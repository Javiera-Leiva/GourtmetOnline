using System;
using System.Collections.Generic;
using System.Text;

namespace GourmetOnline.Core.Domain.Interfaces
{
    public interface ITransaction
    {
        void saveAllChanges();
    }
}
