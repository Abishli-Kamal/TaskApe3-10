using System;

namespace WeekendDay8Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Kamal",20,2000.50);
            Employee employee1 = new Employee("Baxshali",21,800.20);
            Employee employee2 = new Employee("Malik",19,1500.90);
            Employee employee3 = new Employee("Islam", 22, 2200.10);

            Deparment deparment = new Deparment("Bdu",4);

            deparment.AddEmployee(employee);
            deparment.AddEmployee(employee1);
            deparment.AddEmployee(employee2);
            deparment.AddEmployee(employee3);

            foreach (var item in deparment.employees)
            {
                Console.WriteLine(item.ShowInfo());
            }

            Console.WriteLine("\nFoundById");
            Console.WriteLine(deparment[2]);
        }
    }
}
