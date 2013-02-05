using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.ProductCategoryService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the ProductCategory table.
    /// </summary>
    public class ProductCategoryService : IProductCategoryService
    {
        /// <summary>
        /// Gets all product categories.
        /// </summary>
        /// <returns>A list of product category objects.</returns>
        public List<ProductCategory> GetAllProductCategories()
        {
            try
            {
                return new dbSvc().GetAllProductCategories();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the product category by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The product category that matches the id.</returns>
        public ProductCategory GetProductCategoryById(int id)
        {
            try
            {
                return new dbSvc().GetProductCategoryById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the product category record.
        /// </summary>
        /// <param name="productCategory">The product category to delete.</param>
        public void DeleteRecord(ProductCategory productCategory)
        {
            try
            {
                new dbSvc().DeleteRecord(productCategory);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the product category record.
        /// </summary>
        /// <param name="productCategory">The product category to save.</param>
        /// <returns>The id of the saved product category.</returns>
        public int SaveRecord(ProductCategory productCategory)
        {
            try
            {
                return new dbSvc().SaveRecord(productCategory);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
