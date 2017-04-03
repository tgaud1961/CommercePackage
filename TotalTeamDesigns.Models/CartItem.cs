#region 
//------------------------------------------------------------------------
// <copyright file= "CartItem.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 7:57:20 PM</date>
//------------------------------------------------------------------------
#endregion 
namespace TotalTeamDesigns.Models
{   
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts.Models;

    /// <summary>
    /// Cart Item Data Model
    /// </summary>
    public class CartItem : ICartItem
    {
        private Product _product;

        public int CartItemId { get; set; }

        public Guid CartId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public virtual IProduct IProduct { get { return _product as IProduct; } set { _product = value as Product; } }

        public virtual Product Product { get { return _product; } set { _product = value; } }
    }
}