﻿#region

//------------------------------------------------------------------------
// <copyright file= "ICart.cs" company="Total Team Designs">
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

    /// <summary>
    /// Interface class for cart model
    /// </summary>
    public interface ICart
    {
        Guid CartId { get; set; }

        ICollection<ICartItem> ICartItems { get; }

        ICollection<ICartVoucher> ICartVouchers { get; }

        DateTime Date { get; set; }

        void AddCartItem(ICartItem item);

        void AddCartVoucher(ICartVoucher voucher);

        decimal CartTotal();

        decimal CartItemCount();
    }
}