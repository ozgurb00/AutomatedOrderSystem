using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
    }
}
