using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Models
{
    class Recipe
    {
        private bool isTrue = true;
        private int idrecipe = 0;

        private int idProducts = 0;
        private int idDish = 0;
        private double needed_amount = 0;
        private string nameProduct =null;
        public string ErrorString { get; set; }
    
        public bool IsTrue { get { return isTrue; } set { isTrue = value; } }
        public string Idrecipe
        {

            get { return idrecipe.ToString(); }
            set
            {
                bool success = int.TryParse(value, out idrecipe);
                if (success)
                {
                    if (idrecipe <= 0)
                    {
                        ErrorString += "Id рецепта не может быть меньше или равен 0 ";
                        isTrue = false;
                    }

                }
                else
                {
                    ErrorString += "Неверно введен id рецепта";
                    isTrue = false;
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
                        ErrorString += "Id блюда не может быть меньше или равен 0 ";
                        isTrue = false;
                    }

                }
                else
                {
                    ErrorString += "Неверно введен id блюда ";
                    isTrue = false;
                }
            }
        }
        public string Needed_amount
        {

            get { return needed_amount.ToString(); }
            set
            {
                bool success = double.TryParse(value, out needed_amount);
                if (success)
                {
                    if (needed_amount <= 0)
                    {
                        ErrorString += "Колличество нужных ингридиентов не может быть меньше или равен 0 ";
                        isTrue = false;
                    }

                }
                else
                {
                    ErrorString += "Неверно введен колличество нужных ингридиентов ";
                    isTrue = false;
                }
            }
        }
        public string NameProduct
        {
            get { return nameProduct; }
            set
            {
                if (value.Trim() == null || value.Length == 0)
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
    }
}
