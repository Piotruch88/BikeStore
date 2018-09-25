using BikeStore.Models;
using System;
using System.Linq;
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
                      
            if (String.IsNullOrEmpty(guid) == false)
            {
                var sqlCommand = "Select distinct p.Id, p.Name, p.Price, p.Description, p.Producer, p.ProductType, p.URLToPhoto" + Environment.NewLine +
                 "from dbo.ProductOrders po" + Environment.NewLine +
                 "join dbo.Orders o on o.Guid = po.OrderGuid" + Environment.NewLine +
                 "join dbo.Products p on p.Id = po.ProductId" + Environment.NewLine +
                 string.Format("where po.OrderGuid = '{0}'", guid);

                SqlDataSource1.SelectCommand = sqlCommand;

                var order = (from o in _db.Orders
                             select o).Where(o => o.Guid.ToString() == guid).FirstOrDefault();

                LabelAddress.Text = String.Format("Adres Twojego zamówienia: {0}", order.Addres);
            }
        }
    }
}
