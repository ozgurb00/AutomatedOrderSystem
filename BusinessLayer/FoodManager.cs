using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FoodManager
    {
        Repository<Food> repofood = new Repository<Food>();

        public List<Food> GetAll()
        {
            return repofood.List();
        }

    }
}
