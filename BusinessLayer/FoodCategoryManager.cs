using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FoodCategoryManager
    {
        Repository<FoodCategory> repocategory = new Repository<FoodCategory>();
        public List<FoodCategory> GetAll()
        {
            return repocategory.List();
        }

        public int FoodCategoryAddBL(FoodCategory p)
        {
            if(p.CategoryName == "" || p.CategoryName.Length <= 1 || 
                p.CategoryName.Length > 200)
            {
                return -1;
            }
            return repocategory.Insert(p);
        }

        public int DeleteFoodCategoryBL(int p)
        {
            FoodCategory foodCategory = repocategory.Find(x => x.FoodCategoryID == p);
            return repocategory.Delete(foodCategory);
        }

        public int UpdateFoodCategoryBL(FoodCategory p)
        {
            FoodCategory foodCategory = repocategory.Find(x => x.FoodCategoryID == p.FoodCategoryID);
            foodCategory.CategoryName = p.CategoryName;
            return repocategory.Update(foodCategory);
        }
    }
}
