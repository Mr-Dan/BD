using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Models
{
    class Dish
    {
        public int IdDish { get; set; }
        public string NameDish { get; set; }
        public string ReadytTmeDish { get; set; }
        public double CostDish { get; set; }
        public string ImageDish { get; set; }
        public List<Recipe> recipes { get; set; }
    }
}
