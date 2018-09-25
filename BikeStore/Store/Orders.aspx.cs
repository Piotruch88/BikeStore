using BikeStore.Models;
using DevExpress.Web;
using System;
using System.Linq;

namespace BikeStore.Store
{
    public partial class Orders : System.Web.UI.Page
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ASPxGridView1_CustomButtonCallback(object sender, ASPxGridViewCustomButtonCallbackEventArgs e)
        {
            var selectedId = (int)ASPxGridView.GetRowValues(e.VisibleIndex, ASPxGridView.KeyFieldName);

            var guid = from o in _db.Orders
                       where o.Id == selectedId
                       select o.Guid;
            

            ASPxWebControl.RedirectOnCallback("OrderDetails.aspx?orderGuid=" + guid.FirstOrDefault());
        }
    }
}
