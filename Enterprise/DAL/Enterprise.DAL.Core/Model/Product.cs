// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="Product.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using Enterprise.DAL.Core.Service;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class Product
    /// </summary>
    public class Product : ModelBase
    {
        /// <summary>
        /// The _caption
        /// </summary>
        private string _caption;

        /// <summary>
        /// The _category
        /// </summary>
        private ProductCategory _category;

        /// <summary>
        /// The _code
        /// </summary>
        private string _code;

        /// <summary>
        /// The _cost
        /// </summary>
        private decimal _cost;

        /// <summary>
        /// The _product category id
        /// </summary>
        private int _productCategoryId;

        /// <summary>
        /// The _product id
        /// </summary>
        private int _productId;

        /// <summary>
        /// The _rate
        /// </summary>
        private decimal _rate;

        /// <summary>
        /// The _sku
        /// </summary>
        private string _sku;

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product()
        {
            EntityNumber = Product_EntityId;
        }

        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        /// <value>The product id.</value>
        public Int32 ProductId
        {
            get { return _productId; }
            set { SetProperty(ref _productId, value); }
        }

        /// <summary>
        /// Gets or sets the product category id.
        /// </summary>
        /// <value>The product category id.</value>
        public Int32 ProductCategoryId
        {
            get { return _productCategoryId; }
            set { SetProperty(ref _productCategoryId, value); }
        }

        /// <summary>
        /// Gets or sets the caption.
        /// </summary>
        /// <value>The caption.</value>
        public String Caption
        {
            get { return _caption; }
            set { SetProperty(ref _caption, value); }
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        public String Code
        {
            get { return _code; }
            set { SetProperty(ref _code, value); }
        }

        /// <summary>
        /// Gets or sets the SKU.
        /// </summary>
        /// <value>The SKU.</value>
        public String SKU
        {
            get { return _sku; }
            set { SetProperty(ref _sku, value); }
        }

        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        /// <value>The rate.</value>
        public Decimal Rate
        {
            get { return _rate; }
            set { SetProperty(ref _rate, value); }
        }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>The cost.</value>
        public Decimal Cost
        {
            get { return _cost; }
            set { SetProperty(ref _cost, value); }
        }

        /// <summary>
        /// Gets the category.
        /// </summary>
        /// <value>The category.</value>
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

        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>Product.</returns>
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
        /// Saves this instance.
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
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.Product_Delete, _productId));
            CacheItem.Clear<Product>();
        }

        #endregion
    }
}