using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEducation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;
            do
            {
                System.Console.WriteLine("enter pasword");//check pasword if password true you can work with second code
                password = Console.ReadLine();
            } while (password != "$44$6783%");
            System.Console.WriteLine("name:");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Hello  " + $"{name} you  are  welcome");
            System.Console.WriteLine("your age?");
            int age;
            age = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("where do you study?" + "/n kindergarden,school or Univercity?");

            int course;
            string educationlevel = Console.ReadLine();

            switch (educationlevel)
            {

                case "kindergarden":
                    System.Console.WriteLine("1)Qorako'lziyo nur from Tashkent city 2 branch,\n courses "
                + "1*Mathematic"
                + "2*Physics"
                + "3*Biology"
                + "Creative student education \n 2)Ietszone english education 1)Amir Temur street,2)Near Chilanzor metro");
                    course = Convert.ToInt32(Console.ReadLine());
                    switch (course)
                    {
                        case 1:
                            System.Console.WriteLine("Mathematic 650,000 sum Lessons are conducted by experienced teachers");
                            break;
                        case 2:
                            System.Console.WriteLine("Ietszone education Every student's result is important to us"
                        + "\n Our classes are 3 times a week,payment every month 550,000 sum"); break;
                        default: System.Console.WriteLine("NOT AVAILABLE IN THE SYSTEM"); break;
                    }
                    break;

                case " school":
                    System.Console.WriteLine("1)Qorako'lziyo nur from Tashkent city 2 branch,\n courses "
                 + "1*Mathematic"
                 + "2*Physics"
                 + "3*Biology"
                 + "Creative student education \n 2)Ietszone english education 1)Amir Temur street,2)Near Chilanzor metro");
                    course = Convert.ToInt32(Console.ReadLine());
                    switch (course)
                    {
                        case 1: System.Console.WriteLine("Mathematic 650,000 sum Lessons are conducted by experienced teachers"); break;
                        case 2:
                            System.Console.WriteLine("Ietszone education Every student's result is important to us"
                        + "Our classes are 3 times a week,payment every month 550,000 sum"); break;
                        default: System.Console.WriteLine("NOT AVAILABLE IN THE SYSTEM"); break;
                    }
                    break;

                case "univercity":
                    System.Console.WriteLine("1)Qorako'lziyo nur from Tashkent city 2 branch,\n courses "
                + "1*Mathematic"
                + "2*Physics"
                + "3*Biology"
                + "Creative student education \n 2)Ietszone english education 1)Amir Temur street,2)Near Chilanzor metro");
                    course = Convert.ToInt32(Console.ReadLine());
                    switch (course)
                    {
                        case 1:
                            System.Console.WriteLine("1)Mathematic 650,000 sum \n"
                            + "2)Physics 650,000 sum"
                            + "\n Lessons are conducted by experienced teachers"); break;
                        case 2:
                            System.Console.WriteLine("Ietszone education Every student's result is important to us"
                        + "Our classes are 3 times a week,payment every month 550,000 sum "); break;
                        default: System.Console.WriteLine("NOT AVAILABLE IN THE SYSTEM"); break;
                    }
                    break;
                default: Console.WriteLine("NOT AVAILABLE IN THE SYSTEM"); break;
            }
            Console.WriteLine("DIFFICULT DOESN'T MEAN IMPOSSIBLE!");

        }
    }
}
