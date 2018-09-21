using System;

namespace BikeStore.Store
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var products = ASPxGridView.GetSelectedFieldValues("Id");
            var test = products[0].ToString();
        }
    }
}