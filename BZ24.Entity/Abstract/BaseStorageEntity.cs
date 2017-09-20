using System;
using System.Collections.Generic;
using System.Text;

namespace BZ24.Entity.Abstract
{
    public class BaseStorageEntity
    {
        public override int Id { get; set; }
        public override DateTime Created { get; set; }
    }
}
