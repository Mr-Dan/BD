using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Models
{
    class Recipe
    {
        public int Idrecipe { get; set; }
        public int IdProducts { get; set; }
        public int IdDish { get; set; }
        public double Needed_amount { get; set; }
        public string NameProduct { get; set; }
    }
}
