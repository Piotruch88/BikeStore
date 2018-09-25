using System;

namespace BikeStore.Store
{
    public partial class NoPermission : System.Web.UI.Page
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
    }
}