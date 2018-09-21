using BikeStore.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Linq;

namespace BikeStore.Menage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            string currentUserId = User.Identity.GetUserId();

            if (!String.IsNullOrEmpty(currentUserId))
            {
                ApplicationUser currentUser = db.Users.FirstOrDefault(x => x.Id == currentUserId);
                
                if (currentUser.AdminMode)
                {
                    Label1.Visible = false;
                    //ASPxGridView.q
                }
                else
                {
                    Label1.Text = "nie masz uprawnień do tej strony";
                   // ASPxGridView.Visible = false;
                }
            }
            //Context.User.Identity.GetUserId();
        }
    }
}
