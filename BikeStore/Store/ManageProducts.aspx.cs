using BikeStore.Models;
using BikeStore.Store;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;

namespace BikeStore.Store
{
    public partial class ManageProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var helper = new UserPermissionHelper(User.Identity);

            if (helper.UserHasAdminMode == false)
            {
                Response.Redirect("/Store/NoPermission.aspx");
            }
        }     
    }
}
