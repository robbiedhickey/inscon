// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="ProductService.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class ProductService
    /// </summary>
    public class ProductService : ServiceBase<Product>
    {
        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns>List{Product}.</returns>
        public List<Product> GetAllProducts()
        {
            return QueryAll(SqlDatabase, Procedure.Product_SelectAll, Product.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the product by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Product.</returns>
        public Product GetProductById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<Product> h = h2 => h2.ProductId == id;
                return GetAllProducts().Find(h) ?? new Product();
            }

            return Query(SqlDatabase, Procedure.Product_SelectById, Product.Build, id);
        }


        /// <summary>
        /// Gets the products by category id.
        /// </summary>
        /// <param name="categoryId">The category id.</param>
        /// <returns>List{Product}.</returns>
        public List<Product> GetProductsByCategoryId(Int32 categoryId)
        {
            if (IsCached)
            {
                Predicate<Product> h = h2 => h2.ProductCategoryId == categoryId;
                return GetAllProducts().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.Product_SelectByCategoryId, Product.Build, categoryId);
        }
    }
}