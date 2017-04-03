#region 
//------------------------------------------------------------------------
// <copyright file= "IProduct.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 7:33:20 PM</date>
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
    /// Product Interface class
    /// </summary>
    public interface IProduct
    {
        decimal CostPrice { get; set; }

        string Description { get; set; }

        string ImageUrl { get; set; }

        decimal Price { get; set; }

        int ProductId { get; set; }
    }
}
