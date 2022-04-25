using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sallys_collection.EFModels
{
    public partial class ProductType
    {
        public ProductType()
        {
            Product = new HashSet<Product>();
        }

        public string ProductTypeId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
