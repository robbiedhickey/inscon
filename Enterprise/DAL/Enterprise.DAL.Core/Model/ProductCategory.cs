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
        /// Gets or sets the product category ID.
        /// </summary>
        /// <value>The product category ID.</value>
        public Int32 ProductCategoryID
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
    }
}