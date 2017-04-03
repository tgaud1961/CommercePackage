#region 
//------------------------------------------------------------------------
// <copyright file= "Order.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 9:24:06 PM</date>
//------------------------------------------------------------------------
#endregion 
namespace TotalTeamDesigns.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime Date { get; set; }

        public int CustomerId { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}