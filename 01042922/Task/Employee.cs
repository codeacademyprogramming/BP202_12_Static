using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Employee
    {
        public Employee(string position)
        {
            this.Position = position;
            TotalCount++;

            No = position.Substring(0, 2).ToUpper() + (1000 + TotalCount);
        }
        string _fullName;
        public static int TotalCount { get; set; }
        public string FullName
        {
            get => _fullName;
            set
            {
                if (!value.HasDigit())
                    _fullName = value;
            }
        }
        public string No { get; set; }
        public string Position { get; set; }
    }
}
