using BikeStore.Menage;
using BikeStore.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BikeStore.Store
{
    public partial class Products : System.Web.UI.Page
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnAddToShoppingCart_Click(object sender, EventArgs e)
        {
            var selctedIds = ASPxGridView.GetSelectedFieldValues("Id").Cast<int>().ToList();
            var selectedProducts = (from d in db.Products
                                    where selctedIds.Contains(d.Id)
                                    select d).ToList();

            string currentUserId = User.Identity.GetUserId();

            var cart = new ShoppingCart(Session, currentUserId);
            cart.AddProducts(selectedProducts);
        }
    }
}