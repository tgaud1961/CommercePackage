#region 
//---------------------------------------------------------------
// <copyright file= "Cart.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 10:16:41 AM</date>
//---------------------------------------------------------------
#endregion 
namespace TotalTeamDesigns.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts.Models;
    using Models;

    /// <summary>
    /// Cart Data Model
    /// </summary>
    public class Cart : ICart
    {
        private List<CartItem> _cartItems;

        private List<CartVoucher> _cartVoucher;

        public Guid CartId { get; set; }

        public DateTime Date { get; set; }

        public Cart()
        {
            this.CartItems = new List<CartItem>();
            this.CartVouchers = new List<CartVoucher>();
        }

        public decimal CartTotal()
        {
            decimal? total = (from item in CartItems select (int?)item.Quantity * item.Product.Price).Sum();

            return total ?? decimal.Zero;
        }

        public decimal CartItemCount()
        {
            return _cartItems.Count();
        }

        public virtual ICollection<ICartItem> ICartItems { get { return _cartItems.ConvertAll(i => (ICartItem)i); } }

        public virtual ICollection<CartItem> CartItems { get { return _cartItems; } set { _cartItems = value.ToList(); } }

        public virtual ICollection<ICartVoucher> ICartVouchers { get { return _cartVoucher.ConvertAll(i => (ICartVoucher)i); } }

        public virtual ICollection<CartVoucher> CartVouchers { get { return _cartVoucher; } set { _cartVoucher = value.ToList(); } }

        public void AddCartItem(ICartItem item)
        {
            _cartItems.Add((CartItem)item);
        }

        public void AddCartVoucher(ICartVoucher voucher)
        {
            _cartVoucher.Add((CartVoucher)voucher);
        }
    }
}