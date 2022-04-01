using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Muhasib");
            Employee employee2 = new Employee("Proqramist");
            Employee employee3 = new Employee("Muellim");

            Console.WriteLine(Employee.TotalCount);

            Console.WriteLine(employee3.No);

        }
    }
}
