#region

//------------------------------------------------------------------------
// <copyright file= "IeVoucher.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 7:51:49 PM</date>
//------------------------------------------------------------------------
#endregion

namespace TotalTeamDesigns.Contracts.Modules
{
    using Models;

    /// <summary>
    /// E Voucher Interface class
    /// </summary>
    public interface IeVoucher
    {
        void ProcessVoucher(IVoucher voucher, ICart cart, ICartVoucher cartVoucher);
    }
}