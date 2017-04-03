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
    using Contracts.Models;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// 
    /// </summary>
    public class VoucherType : IVoucherType
    {
        public int VoucherTypeId { get; set; }

        public string VoucherModule { get; set; }

        [MaxLength(30)]
        public string Type { get; set; }

        [MaxLength(150)]
        public string Description { get; set; }
    }
}