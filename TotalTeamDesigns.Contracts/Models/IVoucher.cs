#region

//------------------------------------------------------------------------
// <copyright file= "IVoucher.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 7:42:35 PM</date>
//------------------------------------------------------------------------
#endregion

namespace TotalTeamDesigns.Contracts.Models
{
    /// <summary>
    /// Voucher Interface class
    /// </summary>
    public interface IVoucher
    {
        int AppliesToProductId { get; set; }

        string AssignedTo { get; set; }

        decimal MinSpend { get; set; }

        bool MultipleUse { get; set; }

        decimal Value { get; set; }

        string VoucherCode { get; set; }

        string VoucherDescription { get; set; }

        int VoucherId { get; set; }

        int VoucherTypeId { get; set; }
    }
}