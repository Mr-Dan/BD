using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Models
{
    class Warehouse
    {
        private int idProducts = 0;
        private int idProductsWarehouse = 0;       
        private double countProduct = 0;
        private string shelfLifeProduct = null;
        private bool isTrue = true;
        public string ErrorString { get; set; }
        public bool Istrue { get { return isTrue; } set { isTrue = value; } }

        public string ShelfLifeProduct
        {
            get
            {
                return shelfLifeProduct;
            }
            set
            {
                DateTime dateResult;
           
                if (value.Trim() == null)
                {
                    ErrorString += "Введите срок годности";
                    isTrue = false;
                }
              
                else if (!DateTime.TryParseExact(value.Trim(), "MM-dd-yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateResult))
                {
                    ErrorString += "Ошибка в дате или во времеи";
                    isTrue = false;
                }
                else
                {
                    shelfLifeProduct = value;
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

        public int IdProductsWarehouse
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
        public double CountProduct
        {

            get { return countProduct; }
            set
            {
                if (value <= 0)
                {
                    ErrorString += "Колличество товара не может быть меньше или равен 0 ";
                    isTrue = false;
                }
                else
                {
                    countProduct = value;
                }

            }

        }
    }
}