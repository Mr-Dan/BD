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

        public string IdProducts
        {

            get { return idProducts.ToString(); }
            set
            {
                bool success = int.TryParse(value, out idProducts);
                if (success)
                {
                    if (idProducts <= 0)
                    {
                        ErrorString += "Id продукта не может быть меньше или равен 0 ";
                        isTrue = false;
                    }

                }
                else
                {
                    ErrorString += "Неверно введен id продукта ";
                    isTrue = false;
                }
            }

        }

        public string IdProductsWarehouse
        {
            get { return idProductsWarehouse.ToString(); }
            set
            {
                bool success = int.TryParse(value, out idProductsWarehouse);
                if (success)
                {
                    if (idProductsWarehouse <= 0)
                    {
                        ErrorString += "Id не может быть меньше или равен 0 ";
                        isTrue = false;
                    }

                }
                else
                {
                    ErrorString += "Неверно введен id ";
                    isTrue = false;
                }
            }

        }
        public string CountProduct
        {

            get { return countProduct.ToString(); }
            set
            {
                bool success = double.TryParse(value, out countProduct);
                if (success)
                {
                    if (countProduct <= 0)
                    {
                        ErrorString += "Колличество продукта не может быть меньше или равен 0 ";
                        isTrue = false;
                    }

                }
                else
                {
                    ErrorString += "Неверно введено колличество продукта ";
                    isTrue = false;
                }
            }

        }
    }
}