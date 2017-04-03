#region 
//------------------------------------------------------------------------
// <copyright file= "CartVoucher.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 7:58:12 PM</date>
//------------------------------------------------------------------------
#endregion 
namespace TotalTeamDesigns.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts.Models;

    /// <summary>
    /// Cart Voucher Data Class
    /// </summary>
    public class CartVoucher : ICartVoucher
    {
        public int CartVoucherId { get; set; }

        public int VoucherId { get; set; }

        public Guid CartId { get; set; }

        [MaxLength(10)]
        public string VoucherCode { get; set; }

        [MaxLength(100)]
        public string VoucherType { get; set; }

        public decimal Value { get; set; }

        [MaxLength(150)]
        public string VoucherDescription { get; set; }

        public int AppliesToProductId { get; set; }
    }
}