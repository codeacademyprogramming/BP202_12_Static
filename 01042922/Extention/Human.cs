using System;
using System.Collections.Generic;
using System.Text;

namespace Extention
{
    internal class Human
    {
        public Human(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
