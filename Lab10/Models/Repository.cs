using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Lab10.Models
{
    public class Repository
    {
        private static Repository repo = new Repository();
        public static Repository Current
        {
            get
            {
                return repo;
            }
        }

        private List<Order> data = new List<Order>
        {
            new Order
            {OrderId = 1, Name = "Ноутбук", Count = 1, Address = "Пушкина 48"},
            new Order 
            {OrderId = 2, Name = "Фотоаппарат", Count =3, Address = "Бр.Кашириных 152"},
            new Order
            {OrderId=3, Name = "iPhone 6", Count= 5, Address= "Проспект Ленина 81"},
            new Order
            {OrderId=4, Name = "Macbook Air", Count= 10, Address= "Проспект Ленина 81"},
        };

        public IEnumerable<Order> GetAll()
        { 
            return data;
        }

        public Order Get(int id)
        {
            return data.Where(r => r.OrderId == id).FirstOrDefault();
        }

        public Order Add(Order item)
        {
            item.OrderId = data.Count + 1;
            data.Add(item);
            return item;
        }

        public void Remove(int id) 
        {
            Order item = Get(id);
            if (item != null)
            {
                data.Remove(item);
            }
        }

        public bool Update (Order item)
        {
            Order storedItem = Get(item.OrderId);
            if (storedItem != null)
            {
                storedItem.Name = item.Name;
                storedItem.Count = item.Count;
                storedItem.Address = item.Address;
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}