#region

//------------------------------------------------------------------------
// <copyright file= "CartRepository.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/3/2017 5:53:19 AM</date>
//------------------------------------------------------------------------
#endregion

namespace TotalTeamDesigns.DAL.Repositories
{
    using System;
    using Data;
    using Models;
    
    /// <summary>
    /// Cart repository class
    /// </summary>
    public class CartRepository : RepositoryBase<Cart>
    {
        public CartRepository(DataContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}