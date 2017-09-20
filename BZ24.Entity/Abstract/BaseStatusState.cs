using System;
using System.Collections.Generic;
using System.Text;

namespace BZ24.Entity.Abstract
{
    public class BaseStatusState<TStatus, TSubject> : BaseStorageEntity
        where TStatus : struct, IConvertible
        where TSubject : class
    {
        public virtual TStatus New { get; set; }
        public virtual TStatus Old { get; set; }
        public virtual TSubject Subject { get; set; }
    }
}
