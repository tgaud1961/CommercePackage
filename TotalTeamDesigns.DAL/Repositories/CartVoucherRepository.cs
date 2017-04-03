#region

//------------------------------------------------------------------------
// <copyright file= "CartVoucherRepository.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/3/2017 5:57:39 PM</date>
//------------------------------------------------------------------------
#endregion

namespace TotalTeamDesigns.DAL.Repositories
{
    using System;
    using Data;
    using Models;

    /// <summary>
    /// Cart Voucher Repo class
    /// </summary>
    public class CartVoucherRepository : RepositoryBase<CartVoucher>
    {
        public CartVoucherRepository(DataContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}