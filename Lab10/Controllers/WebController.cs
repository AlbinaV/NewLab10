using System;
using System.Collections.Generic;
using System.Web.Http;
using Lab10.Models;

namespace Lab10.Controllers
{
    public class WebController : ApiController
    {
        private Repository repo = Repository.Current;
       
        public IEnumerable<Order> GetAllOrders()
        {
            return repo.GetAll();
        }

        public Order GetOrder(int id)
         {
            return repo.Get(id);
         }

          [HttpPost]
            public Order PostOrder(Order item)
            {
                return repo.Add(item);
            }

           [HttpPut]
            public bool UpdateOrder(Order item)
            {
                return repo.Update(item);
            }

            public void DeleteOrder(int id)
            {
                repo.Remove(id);
            }

	}
}








