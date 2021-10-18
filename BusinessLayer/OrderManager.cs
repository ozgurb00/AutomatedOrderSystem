using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderManager
    {
        Repository<Order> repoorder = new Repository<Order>();

        public List<Order> GetAll()
        {
            return repoorder.List();
        }

        public int OrderAddBL(Order o)
        {
            if(o.CustomerName == "" || o.CustomerName.Length <= 2 || o.CustomerName.Length > 200 ||
             o.OrderAmount <= 0 || o.OrderAmount >= 2140000000 || o.FoodID <= 0 ||o.FoodID >= 2140000000)
            {
                return -1;
            }
            return repoorder.Insert(o);
        }
    }
}
