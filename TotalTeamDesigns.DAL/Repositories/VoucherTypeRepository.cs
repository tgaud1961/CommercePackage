#region

//------------------------------------------------------------------------
// <copyright file= "VoucherTypeRepository.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/3/2017 6:39:08 PM</date>
//------------------------------------------------------------------------
#endregion
namespace TotalTeamDesigns.DAL.Repositories
{
    using System;
    using Data;
    using Models;

    /// <summary>
    ///
    /// </summary>
    public class VoucherTypeRepository : RepositoryBase<VoucherType>
    {
        public VoucherTypeRepository(DataContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}