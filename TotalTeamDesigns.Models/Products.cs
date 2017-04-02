#region 
//---------------------------------------------------------------
// <copyright file= "Products.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// Created: "$DateTime.Now$"
//---------------------------------------------------------------
#endregion 
namespace TotalTeamDesigns.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Product Data Model class
    /// </summary>
    public class Products
    {
        public int ProductId { get; set; }

        public string Description { get; set; }

        [MaxLength(255)]
        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public decimal CostPrice { get; set; }
    }
}