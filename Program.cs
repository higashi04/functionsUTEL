using System;

namespace metodosUTEL
{
    class Program
    {
        static string Greet()
        {
            Console.WriteLine("¿Cuál es su nombre?");
            string userNAme = Console.ReadLine();
            Console.WriteLine("Buen día, {0}" ,userNAme);
            return userNAme;
        }
        static int yearOfBirth()
        {
            Console.WriteLine("¿Cuál es su año de nacimiento?");
            int year = int.Parse(Console.ReadLine());
            int currentAge = DateTime.Today.Year - year;
            return currentAge;
        }
        static int hoursLived(int years) 
        {
            int age = years;
            Console.WriteLine("Su edad es " + age);
            int timeExisted = age*365*24;
            return timeExisted;
        }
        static void existenceAndFarewell(int hours, string user )
        {
            int hoursTotal = hours;
            Console.WriteLine("{0}, usted ha existido por {1} horas", user, hoursTotal);
            Console.WriteLine("Un placer estar con usted, " + user);
        }
        static void Main(string[] args)
        {
            string user = Greet();
            int years = yearOfBirth();
            int hours = hoursLived(years);
            existenceAndFarewell(hours, user);
        }
    }
}
