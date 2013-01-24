using System;
using Enterprise.DAL.Core.Service;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class Product : ModelBase
    {
        private string _caption;
        private ProductCategory _category;
        private string _code;
        private decimal _cost;
        private int _productCategoryId;
        private int _productId;
        private decimal _rate;
        private string _sku;

        public Product()
        {
            EntityNumber = (short)Entities.Product;
        }

        public Int32 ProductId
        {
            get { return _productId; }
            set { SetProperty(ref _productId, value); }
        }

        public Int32 ProductCategoryId
        {
            get { return _productCategoryId; }
            set { SetProperty(ref _productCategoryId, value); }
        }

        public String Caption
        {
            get { return _caption; }
            set { SetProperty(ref _caption, value); }
        }

        public String Code
        {
            get { return _code; }
            set { SetProperty(ref _code, value); }
        }

        public String SKU
        {
            get { return _sku; }
            set { SetProperty(ref _sku, value); }
        }

        public Decimal Rate
        {
            get { return _rate; }
            set { SetProperty(ref _rate, value); }
        }

        public Decimal Cost
        {
            get { return _cost; }
            set { SetProperty(ref _cost, value); }
        }

        public ProductCategory Category
        {
            get
            {
                if (_category != null)
                {
                    return _category;
                }
                _category = new ProductCategoryService().GetProductCategoryById(_productCategoryId);
                return _category;
            }
        }

        #region public methods

        public static Product Build(ITypeReader reader)
        {
            var record = new Product
                {
                    ProductId = reader.GetInt32("ProductID"),
                    ProductCategoryId = reader.GetInt32("ProductCategoryID"),
                    Caption = reader.GetString("Caption"),
                    SKU = reader.GetString("SKU"),
                    Rate = reader.GetDecimal("Rate"),
                    Cost = reader.GetDecimal("Cost")
                };

            return record;
        }

        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_productId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.Product_Update
                                       , _productId
                                       , _productCategoryId
                                       , _caption
                                       , _code
                                       , _sku
                                       , _rate
                                       , _cost));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _productId = Execute(GetCommand(Database.EnterpriseDb, Procedure.Product_Insert
                                                , _productCategoryId
                                                , _caption
                                                , _code
                                                , _sku
                                                , _rate
                                                , _cost), Convert.ToInt32);
                CacheItem.Clear<Product>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.Product_Delete, _productId));
            CacheItem.Clear<Product>();
        }

        #endregion
    }
}