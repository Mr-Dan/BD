using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Models
{
    class Dish
    {
        private int idDish = 0;
        private bool isTrue = true;
        private string nameDish = null;
        private string readytTmeDish = null;
        private double costDish = 0;
        private string imageDish = null;
        private string typeDish = null;
        private int inStock = 0;
        public string ErrorString { get; set; }
       
        public List<Recipe> recipes { get; set; }
        public bool IsTrue { get { return isTrue; } set { isTrue = value; } }
        public string IdDish
        {

            get { return idDish.ToString(); }
            set
            {
                bool success = int.TryParse(value, out idDish);
                if (success)
                {
                    if (idDish <= 0)
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
        public string InStock
        {

            get { return inStock.ToString(); }
            set
            {
                bool success = int.TryParse(value, out inStock);
                if (success)
                {
                    if (inStock < 0 || inStock > 1)
                    {
                        ErrorString += "В наличии не может быть меньше 0 или больше 1";
                        isTrue = false;
                    }

                }
                else
                {
                    ErrorString += "Неверно введен пункт в наличии ";
                    isTrue = false;
                }
            }
        }
        public string NameDish
        {
            get { return nameDish; }
            set
            {
                if (value.Trim() == null || value.Length == 0)
                {
                    ErrorString += "Введите название";
                    isTrue = false;
                }
                else
                {
                    nameDish = value;

                }
            }
        }

        public string ReadytTmeDish
        {
            get { return readytTmeDish; }
            set
            {
                if (value.Trim() == null || value.Length == 0)
                {
                    ErrorString += "Введите время приготовления";
                    isTrue = false;
                }
                else
                {
                    readytTmeDish = value;

                }
            }
        }

        public string CostDish
        {

            get { return costDish.ToString(); }
            set
            {
                bool success = double.TryParse(value, out costDish);
                if (success)
                {
                    if (costDish <= 0)
                    {
                        ErrorString += "Цена не может быть меньше или равен 0 ";
                        isTrue = false;
                    }

                }
                else
                {
                    ErrorString += "Неверно введена цена ";
                    isTrue = false;
                }
            }
        }

        public string ImageDish
        {
            get { return imageDish; }
            set
            {
                if (value.Trim() == null || value.Length == 0)
                {
                    ErrorString += "Введите фото";
                    isTrue = false;
                }
                else
                {
                    imageDish = value;

                }
            }
        }
        public string TypeDish
        {
            get { return typeDish; }
            set
            {
                if (value.Trim() == null || value.Length == 0)
                {
                    ErrorString += "Введите тип блюда";
                    isTrue = false;
                }
                else
                {
                    typeDish = value;

                }
            }
        }
    }
}
