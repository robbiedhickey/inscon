// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="ProductCategory.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class ProductCategory
    /// </summary>
    public class ProductCategory : ModelBase
    {
        /// <summary>
        /// The _code
        /// </summary>
        private string _code;

        /// <summary>
        /// The _name
        /// </summary>
        private string _name;

        /// <summary>
        /// The _product category id
        /// </summary>
        private int _productCategoryId;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCategory"/> class.
        /// </summary>
        public ProductCategory()
        {
            EntityNumber = ProductCategory_EntityId;
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
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public String Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
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
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>ProductCategory.</returns>
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
        /// Saves this instance.
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
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.ProductCategory_Delete, _productCategoryId));
            CacheItem.Clear<ProductCategory>();
        }
    }
}