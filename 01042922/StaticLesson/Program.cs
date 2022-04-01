using System;

namespace StaticLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human(50);
            human1.Name = "Hikmet";

            Console.WriteLine(Human.TotalCount);

            Human human2 = new Human(80);
            human2.Name = "Nermin";

            Human human3 = new Human(180);
            human3.Name = "Nermin";
            Console.WriteLine(Human.TotalCount);


            Console.WriteLine(Calculator.Sum(45, 10));

            Console.WriteLine("=================================\n");

            Console.WriteLine("Adi daxil et");
            string name = Console.ReadLine();

            while (!Human.CheckName(name))
            {
                Console.WriteLine("Adi dogru daxil edin!");
                name = Console.ReadLine();
            }

            Human newHuman = new Human();
            newHuman.Name = name;

            newHuman.Show();

            #region StudentTask
            Console.WriteLine("================ Student task ==============\n");
            
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            Console.WriteLine(student1.No);
            Console.WriteLine(student3.No);
            #endregion
        }

        //static bool CheckName(string name)
        //{
        //    if (!string.IsNullOrWhiteSpace(name) && name.Length > 2 && char.IsUpper(name[0]))
        //    {
        //        for (int i = 1; i < name.Length; i++)
        //        {
        //            if (!char.IsLower(name[i]))
        //                return false;
        //        }

        //        return true;
        //    }

        //    return false;
        //}
    }
}
