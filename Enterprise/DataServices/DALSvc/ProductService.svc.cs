using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.ProductService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the Product table.
    /// </summary>
    public class ProductService : IProductService
    {
        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns>A list of product objects.</returns>
        public List<Product> GetAllProducts()
        {
            try
            {
                return new dbSvc().GetAllProducts();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the product by id.
        /// </summary>
        /// <param name="id">The id of the product.</param>
        /// <returns>The product object that matches the id.</returns>
        public Product GetProductById(int id)
        {
            try
            {
                return new dbSvc().GetProductById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the products by category id.
        /// </summary>
        /// <param name="categoryId">The category id of the products.</param>
        /// <returns>A list of product objects that match the category id.</returns>
        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            try
            {
                return new dbSvc().GetProductsByCategoryId(categoryId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the product record.
        /// </summary>
        /// <param name="product">The product to delete.</param>
        public void DeleteRecord(Product product)
        {
            try
            {
                new dbSvc().DeleteRecord(product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the product record.
        /// </summary>
        /// <param name="product">The product to save.</param>
        /// <returns>The id of the saved product.</returns>
        public int SaveRecord(Product product)
        {
            try
            {
                return new dbSvc().SaveRecord(product);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
