#region 
//------------------------------------------------------------------------
// <copyright file= "VoucherType.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 9:42:39 PM</date>
//------------------------------------------------------------------------
#endregion 
namespace TotalTeamDesigns.Models
{
    using System.ComponentModel.DataAnnotations;
    using Contracts.Models;
    
    /// <summary>
    /// Voucher Type Data model
    /// </summary>
    public class VoucherType : IVoucherType
    {
        public new int VoucherTypeId { get; set; }

        public new string VoucherModule { get; set; }

        [MaxLength(30)]
        public new string Type { get; set; }

        [MaxLength(150)]
        public new string Description { get; set; }
    }
}