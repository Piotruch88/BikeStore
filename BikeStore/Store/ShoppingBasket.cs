using BikeStore.Models;
using System.Collections.Generic;
using System.Web.SessionState;

namespace BikeStore.Menage
{

    public class ShoppingBasket
    {
        private HttpSessionState _session;
        private string _userId;        
        
        public ShoppingBasket(HttpSessionState session, string userId)
        {
            _session = session;
            _userId = userId;
        }
        
        public void AddProducts(List<Product> products)
        {
            _session[_userId] = products;
        }
        
        public List<Product> GetList()
        {
            return (List<Product>)_session[_userId];
        }
        
        public void Clear()
        {
            _session [_userId] = null;
        }

    }
}
