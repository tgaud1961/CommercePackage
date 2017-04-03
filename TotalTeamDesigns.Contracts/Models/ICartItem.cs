#region 
//------------------------------------------------------------------------
// <copyright file= "ICartItem.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 10:16:41 AM</date>
//------------------------------------------------------------------------
#endregion 
namespace TotalTeamDesigns.Contracts.Models
{
    using System;

    public interface ICartItem
    {
        Guid CartId { get; set; }

        int CartItemId { get; set; }

        IProduct IProduct { get; set; }

        int ProductId { get; set; }

        int Quantity { get; set; }
    }
}