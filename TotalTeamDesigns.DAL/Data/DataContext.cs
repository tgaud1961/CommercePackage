#region 
//------------------------------------------------------------------------
// <copyright file= "DataContext.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/3/2017 5:57:50 AM</date>
//------------------------------------------------------------------------
#endregion 
namespace TotalTeamDesigns.DAL.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models;
    using System.Data.Entity;

    /// <summary>
    /// Absract Data Context class
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// you can either pass the NAME of a conenction string (e.g. from a web.config), and explicitly delcare it.
        /// </summary>
        public DataContext() : base("DefaultConnection")
        {
        }

        /// <summary>
        /// any entity to be persisted must me delcared here.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Voucher> Vouchers { get; set; }

        public DbSet<CartVoucher> CartVouchers { get; set; }

        public DbSet<VoucherType> VoucherTypes { get; set; }
    }
}