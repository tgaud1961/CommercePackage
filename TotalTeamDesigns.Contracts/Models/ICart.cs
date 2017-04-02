#region 
//------------------------------------------------------------------------
// <copyright file= "$safeitemrootname$.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 10:16:41 AM</date>
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
    /// Interface class for cart model
    /// </summary>
    public interface ICart
    {
        Guid CartId { get; set; }

        ICollection<ICartItem> ICartItems { get; }

        ICollection<ICartVoucher> ICartVouchers { get; }

        DateTime date { get; set; }

        void AddCartItem(ICartItem item);

        void AddCartVoucher(ICartVoucher voucher);

        decimal CartTotal();

        decimal CartItemCount();
    }
}