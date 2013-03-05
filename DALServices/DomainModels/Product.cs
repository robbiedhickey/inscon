using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Product
    {
        public int ProductID { get; set; }
        public int ProductCategoryID { get; set; }
        public string Caption { get; set; }
        public string Code { get; set; }
        public string SKU { get; set; }
        public decimal Rate { get; set; }
        public decimal Cost { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
