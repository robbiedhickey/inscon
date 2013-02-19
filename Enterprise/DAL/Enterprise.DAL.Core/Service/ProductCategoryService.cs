// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="ProductCategoryService.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class ProductCategoryService
    /// </summary>
    public class ProductCategoryService : ServiceBase<ProductCategory>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>ProductCategory.</returns>
        public static ProductCategory Build(ITypeReader reader)
        {
            var record = new ProductCategory
                {
                    ProductCategoryID = reader.GetInt32("ProductCategoryID"),
                    Name = reader.GetString("Name"),
                    Code = reader.GetString("Code")
                };

            return record;
        }


        /// <summary>
        /// Gets all product categories.
        /// </summary>
        /// <returns>List{ProductCategory}.</returns>
        public List<ProductCategory> GetAllProductCategories()
        {
            return QueryAll(SqlDatabase, Procedure.ProductCategory_SelectAll, Build,
                            CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the product category by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>ProductCategory.</returns>
        public ProductCategory GetProductCategoryById(int id)
        {
            if (IsCached)
            {
                Predicate<ProductCategory> h = h2 => h2.ProductCategoryID == id;
                return GetAllProductCategories().Find(h) ?? new ProductCategory();
            }

            return Query(SqlDatabase, Procedure.ProductCategory_SelectById, Build, id);
        }
    }
}