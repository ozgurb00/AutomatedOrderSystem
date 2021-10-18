using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class FoodCategory
    {
        [Key]
        public int FoodCategoryID { get; set; }
        [StringLength(200)]
        public string CategoryName { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
