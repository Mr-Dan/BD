using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Models
{
    class Ingredient
    {
        public int IdProducts { get; set; }
        public double Needed_amount { get; set; }

        bool istrue = true;
        public bool Istrue { get { return istrue; } set { istrue = value; } }
        public string NameProduct { get; set; }
    }
}
