#region 
//------------------------------------------------------------------------
// <copyright file= "IVoucherType.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 7:43:10 PM</date>
//------------------------------------------------------------------------
#endregion 
namespace TotalTeamDesigns.Contracts.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Voucher Type Interface class
    /// </summary>
    public class IVoucherType
    {
        public string Description { get; set; }

        public string Type { get; set; }

        public string VoucherModule { get; set; }

        public int VoucherTypeId { get; set; }
    }
}