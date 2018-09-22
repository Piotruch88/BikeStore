using BikeStore.Menage;
using BikeStore.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;

namespace BikeStore.Store
{
    public partial class ManageBasket : System.Web.UI.Page
    {
        public List<Product> _basketGridPresenter;

        protected void Page_Load(object sender, EventArgs e)
        {
            //_basketGridPresenter = new ShoppingBasket(Session, User.Identity.GetUserId()).GetList();
        }
        
        public DataSet LoadToGrid()
        {
            _basketGridPresenter = new ShoppingBasket(Session, User.Identity.GetUserId()).GetList();

            var test = new DataSet();

            return test;
        }

        public List<int> LoadCzyToSiePOkaze()
        {           
            var test = new List<int>();
            test.Add(23);
            test.Add(23);

            return test;
        }


    }
}
