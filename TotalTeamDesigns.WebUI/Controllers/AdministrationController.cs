#region
//------------------------------------------------------------------------
// <copyright file= "AdministrationController.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/3/2017 6:02:50 PM</date>
//------------------------------------------------------------------------
#endregion

namespace TotalTeamDesigns.WebUI.Controllers
{
    using System.Web.Mvc;
    using TotalTeamDesigns.Contracts.Repositories;
    using TotalTeamDesigns.Models;

    /// <summary>
    /// Administration Controller
    /// </summary>
    public class AdministrationController : Controller
    {
        private IRepositoryBase<Customer> customers;
        private IRepositoryBase<Product> products;
        private IRepositoryBase<VoucherType> voucherTypes;
        private IRepositoryBase<Voucher> vouchers;

        public AdministrationController(IRepositoryBase<Customer> customers, IRepositoryBase<Product> products, IRepositoryBase<VoucherType> voucherTypes, IRepositoryBase<Voucher> vouchers)
        {
            this.customers = customers;
            this.products = products;
            this.voucherTypes = voucherTypes;
            this.vouchers = vouchers;
        }

        // GET: Administration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductList()
        {
            var model = products.GetAll();

            return View(model);
        }

        public ActionResult CreateProduct()
        {
            var model = new Product();

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            products.Insert(product);
            products.Commit();

            return RedirectToAction("ProductList");
        }

        public ActionResult EditProduct(int id)
        {
            Product product = products.GetById(id);

            return View(product);
        }

        [HttpPost]
        public ActionResult EditProduct(Product product)
        {
            products.Update(product);
            products.Commit();

            return RedirectToAction("ProductList");
        }
    }
}