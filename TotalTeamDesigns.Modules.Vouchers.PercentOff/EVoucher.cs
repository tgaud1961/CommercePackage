#region

//------------------------------------------------------------------------
// <copyright file= "EVoucher.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/3/2017 6:54:29 PM</date>
//------------------------------------------------------------------------
#endregion

namespace TotalTeamDesigns.Modules.Vouchers.PercentOff
{
    using Contracts.Models;
    using Contracts.Modules;

    /// <summary>
    ///
    /// </summary>
    public class EVoucher : IeVoucher
    {
        public void ProcessVoucher(IVoucher voucher, ICart cart, ICartVoucher cartVoucher)
        {
            if (voucher.MinSpend < cart.CartTotal())
            {
                cartVoucher.Value = voucher.Value * (cart.CartTotal() / 100);
                cartVoucher.VoucherCode = voucher.VoucherCode;
                cartVoucher.VoucherDescription = cartVoucher.VoucherDescription;
                cartVoucher.VoucherId = cartVoucher.VoucherId;
                cart.AddCartVoucher(cartVoucher);
            }
        }
    }
}