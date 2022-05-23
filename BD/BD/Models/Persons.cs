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

        private int idPerson = 0;
        private string namePerson = null;
        private string lastNamePerson = null;
        private string middleNamePerson = null;
        private string positionPerson = null;
        private int agePerson = 0;
        private string login = null;
        private string password = null;
        private string privileges = null;

       
        public bool IsTrue { get { return isTrue; } set { isTrue = value; } }
        public string ErrorString { get; set; }
        public string NamePerson
        {
            get { return namePerson; }
            set
            {
                if (value.Length > 0)
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
                if (value.Trim() == null || value.Length == 0)
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
                if (value.Trim() == null || value.Length == 0)
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
                if (value.Trim() == null || value.Length == 0)
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
        public string AgePerson
        {

            get { return agePerson.ToString(); }
            set
            {
                bool success = int.TryParse(value, out agePerson);
                if (success)
                {
                    if (agePerson <= 0)
                    {
                        ErrorString += "Возраст не может быть меньше или равен 0 ";
                        isTrue = false;
                    }
                    
                }
                else
                {
                    ErrorString += "Неверно введен возраст ";
                    isTrue = false;
                }
            }
        }
        public string IdPerson
        {

            get { return idPerson.ToString(); }
            set
            {
                bool success = int.TryParse(value, out idPerson);
                if (success)
                {
                    if (idPerson <= 0)
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
        public string Login
        {
            get { return login; }
            set
            {
                if (value.Trim() == null || value.Length == 0)
                {
                    ErrorString += "Введите логин";
                    isTrue = false;
                }
                else
                {
                    login = value;

                }
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Trim() == null || value.Length == 0)
                {
                    ErrorString += "Введите пароль";
                    isTrue = false;
                }
                else
                {
                    password = value;

                }
            }
        }
        public string Privileges
        {
            get { return privileges; }
            set
            {
                if (value.Trim() == null || value.Length == 0)
                {
                    ErrorString += "Введите привилегию";
                    isTrue = false;
                }
                else
                {
                    privileges = value;

                }
            }
        }
    }
}
