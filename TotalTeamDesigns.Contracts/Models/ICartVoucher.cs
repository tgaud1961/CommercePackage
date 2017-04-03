#region

//------------------------------------------------------------------------
// <copyright file= "ICartVoucher.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 10:16:41 AM</date>
//------------------------------------------------------------------------
#endregion

namespace TotalTeamDesigns.Contracts.Models
{
    using System;

    public interface ICartVoucher
    {
        int AppliesToProductId { get; set; }

        Guid CartId { get; set; }

        int CartVoucherId { get; set; }

        decimal Value { get; set; }

        string VoucherCode { get; set; }

        string VoucherDescription { get; set; }

        int VoucherId { get; set; }

        string VoucherType { get; set; }
    }
}