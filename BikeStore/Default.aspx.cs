using BikeStore.Menage;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeStore {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            var basket = new ShoppingBasket(Session, User.Identity.GetUserId());
            var list = basket.GetProductList();
        }
        
    }
}