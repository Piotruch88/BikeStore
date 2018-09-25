using BikeStore.Menage;
using BikeStore.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BikeStore.Store
{
    public partial class ManageBasket : System.Web.UI.Page
    {
        private void CheckUserPermission()
        {
            var helper = new UserPermissionHelper(User.Identity);
            if (helper.UserIsLogged == false)
            {
                Response.Redirect("/Account/Login.aspx");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CheckUserPermission();
        }

        public List<Product> GetBasket()
        {
            var basket = new ShoppingBasket(Session, User.Identity.GetUserId());

            if (basket != null)
            {
                return basket.GetProductList();
            }
            else
            {
                return null;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var basket = new ShoppingBasket(Session, User.Identity.GetUserId());
            var selctedIds = ASPxGridView.GetSelectedFieldValues("Id").Cast<int>().ToList();

            foreach (var selId in selctedIds)
            {
                basket.RemoveProduct(selId);
            }

            Response.Redirect(Request.RawUrl);
        }

        protected void BtnOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Store/OrderSummary.aspx");
        }
    }
}
