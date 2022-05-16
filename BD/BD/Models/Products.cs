using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Models
{
    class Products
    {
        private int idProducts = 0;
        private string nameProduct = null;
        private string unitProduct = null;
        private bool isTrue = true;
        public string ErrorString { get; set; }
        public bool Istrue { get { return isTrue; } set { isTrue = value; } }
        public string NameProduct 
        {
            get
            {
                return nameProduct;
            }
            set
            {
                if (value.Trim() == null)
                {
                    ErrorString += "Введите название продукта";
                    isTrue = false;
                }
                else
                {
                    nameProduct = value;
                }
            }
        }
        public string UnitProduct
        {
            get
            {
                return unitProduct;
            }
            set
            {
                if (value.Trim() == null)
                {
                    ErrorString += "Введите единицу измерения";
                    isTrue = false;
                }
                else
                {
                    unitProduct = value;
                }
            }
        }

        public int IdProducts
        {

            get { return idProducts; }
            set
            {
                if (value <= 0)
                {
                    ErrorString += "id не может быть меньше или равен 0 ";
                    isTrue = false;
                }
                else
                {
                    idProducts = value;
                }

            }

        }
    
    }
}
