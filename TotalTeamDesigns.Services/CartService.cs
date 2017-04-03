#region

//------------------------------------------------------------------------
// <copyright file= "CartServices.cs" company="Total Team Designs">
// Copyright (c) 2017 Total Team Designs. All rights reserved
// </copyright>
// Author: Tom Gauden
// <date>4/3/2017 7:00:42 PM</date>
//------------------------------------------------------------------------
#endregion

namespace TotalTeamDesigns.Services
{
    using System;
    using System.Linq;
    using System.Web;
    using Contracts.Repositories;
    using Models;

    /// <summary>
    ///
    /// </summary>
    public class CartService
    {
        private IRepositoryBase<Cart> carts;
        private IRepositoryBase<Voucher> vouchers;
        private IRepositoryBase<VoucherType> voucherTypes;
        private IRepositoryBase<CartVoucher> cartVouchers;

        public const string CartSessionName = "eCommerceCart";

        public CartService(IRepositoryBase<Cart> carts, IRepositoryBase<Voucher> vouchers, IRepositoryBase<CartVoucher> cartVouchers, IRepositoryBase<VoucherType> voucherTypes)
        {
            this.carts = carts;
            this.vouchers = vouchers;
            this.cartVouchers = cartVouchers;
            this.voucherTypes = voucherTypes;
        }

        private Cart CreateNewCart(HttpContextBase httpContext)
        {
            HttpCookie cookie = new HttpCookie(CartSessionName);
            Cart cart = new Cart();
            cart.Date = DateTime.Now;
            cart.CartId = Guid.NewGuid();
            ////
            carts.Insert(cart);
            carts.Commit();
            ////
            cookie.Value = cart.CartId.ToString();
            cookie.Expires = DateTime.Now.AddDays(1);
            httpContext.Response.Cookies.Add(cookie);

            return cart;
        }

        public bool AddToCart(HttpContextBase httpContext, int productId, int quantity)
        {
            bool success = true;

            Cart cart = GetCart(httpContext);
            CartItem item = cart.CartItems.FirstOrDefault(i => i.ProductId == productId);
            if (item == null)
            {
                item = new CartItem()
                {
                    CartId = cart.CartId,
                    ProductId = productId,
                    Quantity = quantity
                };
                cart.AddCartItem(item);
            }
            else
            {
                item.Quantity = item.Quantity + quantity;
            }
            carts.Commit();

            return success;
        }

        private Cart GetCart(HttpContextBase httpContext)
        {
            HttpCookie cookie = httpContext.Request.Cookies.Get(CartSessionName);
            Cart cart;
            Guid cartId;

            if (cookie != null)
            {
                if (Guid.TryParse(cookie.Value, out cartId))
                {
                    cart = carts.GetById(cartId);
                }
                else
                {
                    cart = CreateNewCart(httpContext);
                }
            }
            else
            {
                cart = CreateNewCart(httpContext);
            }

            return cart;
        }

        public void AddVoucher(string voucherCode, HttpContextBase httpContext)
        {
            Cart cart = GetCart(httpContext);
            Voucher voucher = vouchers.GetAll().FirstOrDefault(v => v.VoucherCode == voucherCode);

            if (voucher != null)
            {
                VoucherType voucherType = voucherTypes.GetById(voucher.VoucherTypeId);
                if (voucherType != null)
                {
                    CartVoucher cartVoucher = new CartVoucher();
                    if (voucherType.Type == "MoneyOff")
                    {
                        MoneyOff(voucher, cart, cartVoucher);
                    }
                    if (voucherType.Type == "PercentOff")
                    {
                        PercentOff(voucher, cart, cartVoucher);
                    }

                    carts.Commit();
                }
            }
        }

        public void MoneyOff(Voucher voucher, Cart cart, CartVoucher cartVoucher)
        {
            decimal cartTotal = cart.CartTotal();
            if (voucher.MinSpend < cartTotal)
            {
                cartVoucher.Value = voucher.Value * -1;
                cartVoucher.VoucherCode = voucher.VoucherCode;
                cartVoucher.VoucherDescription = voucher.VoucherDescription;
                cartVoucher.VoucherId = voucher.VoucherId;
                cart.AddCartVoucher(cartVoucher);
            }
        }

        public void PercentOff(Voucher voucher, Cart cart, CartVoucher cartVoucher)
        {
            if (voucher.MinSpend > cart.CartTotal())
            {
                cartVoucher.Value = (voucher.Value * (cart.CartTotal() / 100)) * -1;
                cartVoucher.VoucherCode = voucher.VoucherCode;
                cartVoucher.VoucherDescription = voucher.VoucherDescription;
                cartVoucher.VoucherId = voucher.VoucherId;
                cart.AddCartVoucher(cartVoucher);
            }
        }
    }
}