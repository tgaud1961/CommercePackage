#region

//------------------------------------------------------------------------
// <copyright file= "Voucher.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 9:30:11 PM</date>
//------------------------------------------------------------------------
#endregion

namespace TotalTeamDesigns.Models
{
    using System.ComponentModel.DataAnnotations;
    using Contracts.Models;

    /// <summary>
    /// Voucher data model class
    /// </summary>
    public class Voucher : IVoucher
    {
        public int VoucherId { get; set; }

        [MaxLength(10)]
        public string VoucherCode { get; set; }

        public int VoucherTypeId { get; set; }

        [MaxLength(150)]
        public string VoucherDescription { get; set; }

        ////Applies to specific product
        public int AppliesToProductId { get; set; }

        public decimal Value { get; set; }

        public decimal MinSpend { get; set; }

        public bool MultipleUse { get; set; }

        [MaxLength(255)]
        public string AssignedTo { get; set; }
    }
}