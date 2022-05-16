using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Models
{
    class Person
    {
        private bool isTrue = true;


        private string namePerson = null;
        private string lastNamePerson = null;
        private string middleNamePerson = null;
        private string positionPerson = null;
        private int agePerson = 0;
        int idPerson { get; set; }
        public bool IsTrue { get { return isTrue; } set { isTrue = value; } }
        public string ErrorString { get; set; }
        public string NamePerson
        {
            get { return namePerson; }
            set
            {
                if (value.Trim() == null)
                {
                    ErrorString += "Введите Имя";
                    isTrue = false;
                }
                else
                {
                    namePerson = value;

                }
            }
        }
        public string LastNamePerson
        {
            get { return lastNamePerson; }
            set
            {
                if (value.Trim() == null)
                {
                    ErrorString += "Введите Фамилию";
                    isTrue = false;
                }
                else
                {
                    lastNamePerson = value;

                }
            }
        }
        public string MiddleNamePerson
        {
            get { return middleNamePerson; }
            set
            {
                if (value.Trim() == null)
                {
                    ErrorString += "Введите Отчество";
                    isTrue = false;
                }
                else
                {
                    middleNamePerson = value;
                }
            }
        }
        public string PositionPerson
        {
            get { return positionPerson; }
            set
            {
                if (value.Trim() == null)
                {
                    ErrorString += "Введите должность";
                    isTrue = false;
                }
                else
                {
                    positionPerson = value;
                }
            }
        }
        public int AgePerson
        {

            get { return agePerson; }
            set
            {
                if (value <= 0)
                {
                    ErrorString += "Возраст не может быть меньше или равен 0 ";
                    isTrue = false;
                }
                else
                {
                    agePerson = value;
                }

            }
        }

    }
}
