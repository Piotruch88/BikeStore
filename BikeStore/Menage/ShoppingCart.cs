using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace BikeStore.Menage
{
    public class Product
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
    }
    public class ShoppingCart
    {
        HttpSessionState _session;
        public ShoppingCart(HttpSessionState session)
        {
            this._session = session;
        }
        public string Id = "Piotrek";
        public List<Product> Products { get; set; }
        public void AddProduct(Product product)
        {
            List<Product> Products = (List<Product>)this._session[this.Id];
            if (Products != null)
            {
                Products.Add(product);
            }
            else
            {
                Products = new List<Product>();
            }
            this._session[this.Id] = Products;
        }
        public List<Product> GetList()
        {
            return (List<Product>)this._session[this.Id];
        }

    }
}