using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Fashinista.core.common
{
   public interface IdbContext
    {
        public DbConnection connection { get; }
    }
}
