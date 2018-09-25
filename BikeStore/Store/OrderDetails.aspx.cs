using BikeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeStore.Store
{
    public partial class OrderDetails : System.Web.UI.Page
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            Label.Text = "Szczegóły zamówienia";

            var guid = Request.QueryString["orderGuid"];
                        
            var sqlCommand = "Select distinct p.Id, p.Name, p.Price, p.Description, p.Producer, p.ProductType, p.URLToPhoto" + Environment.NewLine +
                             "from dbo.ProductOrders po" + Environment.NewLine +
                             "join dbo.Orders o on o.Guid = po.OrderGuid" + Environment.NewLine +
                             "join dbo.Products p on p.Id = po.ProductId" + Environment.NewLine +
                             string.Format("where po.OrderGuid = '{0}'", guid);

            SqlDataSource1.SelectCommand = sqlCommand;
        }
        

    }
}
