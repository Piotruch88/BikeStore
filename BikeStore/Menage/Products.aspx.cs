using BikeStore.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;

namespace BikeStore.Menage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private void NoPermission()
        {
            ASPxGridView.Visible = false;
            Label1.Text = "Nie posiadasz uprawnień do tej strony";
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            string currentUserId = User.Identity.GetUserId();

            if (!String.IsNullOrEmpty(currentUserId))
            {
                ApplicationUser currentUser = db.Users.FirstOrDefault(x => x.Id == currentUserId);

                if (currentUser.AdminMode)
                {
                    ASPxGridView.Visible = true;
                    Label1.Visible = false;
                }
                else
                    NoPermission();
            }
            else
                NoPermission();

            //Context.User.Identity.GetUserId();
        }
    }
}
