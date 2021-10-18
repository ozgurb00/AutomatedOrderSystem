using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Food
    {
        [Key]
        public int FoodID { get; set; }

        [StringLength(200)]
        public string FoodName { get; set; }
        public decimal FoodPrice { get; set; }
        public int FoodCategoryID { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
