using System;

namespace Extention
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Hik1met";
            var check = name.IsConsistOfDigits();

            check = name.HasDigit();

            Console.WriteLine(check);


            int num = 56;
            int sum = num.Add(45);

            var num2 = 0;

            Console.WriteLine(num.IsEven());

            Human human = new Human("Hikmet", "Abbasov");
            //Student student = new Student("Abbbas", "Abbasov");
            human.Show();
        }
    }
}
