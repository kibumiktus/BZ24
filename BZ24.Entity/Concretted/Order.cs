using BZ24.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace BZ24.Entity.Concretted
{
    public class Order : BaseStorageEntity
    {
        public virtual IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
