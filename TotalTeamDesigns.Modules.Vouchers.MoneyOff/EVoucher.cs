#region 
//------------------------------------------------------------------------
// <copyright file= "EVoucher.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/3/2017 6:45:37 PM</date>
//------------------------------------------------------------------------
#endregion 
namespace TotalTeamDesigns.Modules.Vouchers.MoneyOff
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts.Modules;
    using Contracts.Models;

    /// <summary>
    /// 
    /// </summary>
    class EVoucher : IeVoucher
    {
        public void ProcessVoucher(IVoucher voucher, ICart cart, ICartVoucher cartVoucher)
        {
            if (voucher.MinSpend < cart.CartTotal())
            {
                cartVoucher.Value = voucher.Value;
                cartVoucher.VoucherCode = voucher.VoucherCode;
                cartVoucher.VoucherDescription = cartVoucher.VoucherDescription;
                cartVoucher.VoucherId = cartVoucher.VoucherId;
                cart.AddCartVoucher(cartVoucher);
            }
        }
    }
}