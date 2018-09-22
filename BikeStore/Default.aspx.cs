using BikeStore.Menage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeStore {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            var cart = new ShoppingCart(Session);
            var list = cart.GetList();
        }
        
    }
}