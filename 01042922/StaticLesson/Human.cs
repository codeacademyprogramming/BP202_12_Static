using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLesson
{
    internal class Human
    {
        static Human()
        {
            Num = 40;
        }
        public Human(int num)
        {
            Num = num;
            TotalCount++;
        }

        public Human()
        {
            TotalCount++;
        }
        public static int Num;
        public static int TotalCount { get; set; }
        string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (CheckName(value))
                    _name = value;
            }
        }
        public string Surname { get; set; }

        public static void ShowTotalCount()
        {
            Console.WriteLine(TotalCount);
        }

        public void Show()
        {
            Console.WriteLine($"{this.Name} {this.Surname}");
        }

        public static bool CheckName(string name)
        {
            if(!string.IsNullOrWhiteSpace(name) && name.Length > 2 && char.IsUpper(name[0]))
            {
                for (int i = 1; i < name.Length; i++)
                {
                    if (!char.IsLower(name[i]))
                        return false;
                }

                return true;
            }

            return false;
        }
    }
}
