using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    internal class Reader
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public Reader(string name, string surname, string patronymic, string phone)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Phone = phone;
        }
    }
}
