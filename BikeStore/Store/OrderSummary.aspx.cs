using BikeStore.Menage;
using BikeStore.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeStore.Store
{
    public partial class OrderSummary : System.Web.UI.Page
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

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
            var basket = new ShoppingBasket(Session, User.Identity.GetUserId());
            Label.Text = "Wartość Twojego zamówienia wynosi: " + basket.GetTotalCost().ToString();
        }

        protected void Btn_SubmitOrder_Click(object sender, EventArgs e)
        {
            var guid = Guid.NewGuid();
            var basket = new ShoppingBasket(Session, User.Identity.GetUserId());

            var order = new Order
            {
                Addres = ASPxMemo1.Text,
                TimeCreate = DateTime.Now,
                UserIdPlacing = User.Identity.GetUserId(),
                Price = basket.GetTotalCost(),
                Guid = guid,
            };
            _db.Orders.Add(order);

            var productsInBasket = basket.GetProductList();

            foreach (var product in productsInBasket)
            {
                _db.ProductsOrders.Add(
                    new ProductOrder
                    {
                        OrderGuid = guid,
                        ProductId = product.Id
                    });
            }

            basket.Clear();
            _db.SaveChanges();
            
            var msg = "Dzięujemy za złożenie zamówienia";
            var urlRedirect = String.Format("/Store/OrderDetails.aspx?orderGuid={0}&msg={1}", guid, msg);

            Response.Redirect(urlRedirect);
        }
    }
}
