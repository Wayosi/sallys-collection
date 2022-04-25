using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sallys_collection.EFModels
{
    public partial class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string MainImage { get; set; }
        public string ProductTypeId { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
