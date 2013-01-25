using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class ProductCategory : ModelBase
    {
        private string _code;
        private string _name;
        private int _productCategoryId;

        public ProductCategory()
        {
            EntityNumber = (short) Entities.ProductCategory;
        }

        public Int32 ProductCategoryId
        {
            get { return _productCategoryId; }
            set { SetProperty(ref _productCategoryId, value); }
        }

        public String Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public String Code
        {
            get { return _code; }
            set { SetProperty(ref _code, value); }
        }

        public static ProductCategory Build(ITypeReader reader)
        {
            var record = new ProductCategory
                {
                    ProductCategoryId = reader.GetInt32("ProductCategoryID"),
                    Name = reader.GetString("name"),
                    Code = reader.GetString("Code")
                };

            return record;
        }

        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_productCategoryId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.ProductCategory_Update
                                       , _productCategoryId
                                       , _name
                                       , _code));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _productCategoryId = Execute(GetCommand(Database.EnterpriseDb, Procedure.ProductCategory_Insert
                                                        , _name
                                                        , _code), Convert.ToInt32);
                CacheItem.Clear<ProductCategory>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.ProductCategory_Delete, _productCategoryId));
            CacheItem.Clear<ProductCategory>();
        }
    }
}