﻿using BikeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            List<Product> basket = (List<Product>)_session[_userId];
            if (basket == null)
                basket = new List<Product>();
            
            basket = GetOnlyUniqeRecord(basket, products);

            _session[_userId] = basket;
        }

        private List<Product> GetOnlyUniqeRecord(List<Product> basket, List<Product> products)
        {
            foreach (var product in products)
                if (basket.Any(b => b.Id == product.Id) == false)
                    basket.Add(product);

            return basket;
        }

        public List<Product> GetProductList()
        {
            return (List<Product>)_session[_userId];
        }

        public List<Product> RemoveProduct(int Id)
        {
            var newBasketList = new List<Product>();

            foreach (var oldRec in GetProductList())
            {
                if (Id != oldRec.Id)
                    newBasketList.Add(oldRec);
            }

            Clear();
            AddProducts(newBasketList);

            return GetProductList();
        }

        public void Clear()
        {
            _session [_userId] = null;
        }

        public decimal GetTotalCost()
        {
            decimal result = 0;
            var productList = GetProductList();

            if (productList != null)
            {
                foreach (var product in productList)
                {
                    result = result + product.Price;
                }
            }

            return result;
        }
    }
}
