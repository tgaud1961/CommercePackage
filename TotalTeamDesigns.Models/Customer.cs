#region 
//---------------------------------------------------------------
// <copyright file= "Customer.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/2/2017 9:58:00 AM</date>
//---------------------------------------------------------------
#endregion 
namespace TotalTeamDesigns.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Customer Data Entry model
    /// </summary>
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string Address1 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Phone { get; set; }

        [DisplayName("Email :")]
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}