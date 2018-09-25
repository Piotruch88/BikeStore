using BikeStore.Models;
using DevExpress.Web;
using System;
using System.Linq;

namespace BikeStore.Store
{
    public partial class Orders : System.Web.UI.Page
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
