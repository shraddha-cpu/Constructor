using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (employee)
            /*  Employee emp1 = new Employee();
              Console.WriteLine(emp1.DisplayDetails());
              emp1.CalculateSalary();

              Employee emp2 = new Employee(2,50000,4000,"shree");
              Console.WriteLine(emp2.DisplayDetails());
              emp2.CalculateSalary(); */


            // (student)

            /*   Student s1 = new Student();
                s1.Calculateper();
                Console.WriteLine(s1.DisplayDetails());

               Student s2 = new Student(1,"shraddha paygude",88,78,90);
                s2.Calculateper();
               Console.WriteLine(s2.DisplayDetails());  */


            // (circle)
            /* Circle c1 = new Circle();
             c1.CalculateArea(); 
            Console.WriteLine(c1.DisplayDetails());

            Circle c2 = new Circle(2);
            c2.CalculateArea();
            Console.WriteLine(c2.DisplayDetails());  */

            // (Rectangle)
            /*  Rectangle rec1 = new Rectangle();
              rec1.CalculatePerimeter();
              Console.WriteLine(rec1.DisplayDetails());

              Rectangle rec2 = new Rectangle(4,3);
              rec2.CalculatePerimeter();
              Console.WriteLine(rec2.DisplayDetails()); */

            //(employee)
            EmployeeSalary emp1 = new EmployeeSalary(75000, "neha", 200);
            emp1.CalculateSalary();
            Console.WriteLine(emp1.DisplayDetails());

            





        }
    }
}
