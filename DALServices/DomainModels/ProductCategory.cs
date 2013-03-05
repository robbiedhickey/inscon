using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            this.Products = new List<Product>();
        }

        public int ProductCategoryID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
