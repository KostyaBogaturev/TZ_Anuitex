namespace TestTask
{
    using System;
    using Models;
    using Helper;
    public class Program
    {

        static void Main(string[] args)
        {
            var firm = new Firm();

            var worker = new Worker("Anton I.", 23);
            firm = firm + worker;

            var firstManager = new Manager("Julia K.", 35);
            var secondManager = new Manager("Kostia B.", 19);
            firm = firm + firstManager + secondManager;

            var foreman = new Foreman("Natasha Ch.", 54);
            firm = firm + foreman;

            firm.Print();
            Console.WriteLine();

            firm = firm - foreman;
            firm.Print();
            Console.WriteLine();

            var list = firm.GetEmployee<Manager>();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine($"Count of managers :{firm.CountOfEmployee<Manager>()}");
            Console.WriteLine($"Count of foremen :{firm.CountOfEmployee<Foreman>()}");
            Console.WriteLine();

            Console.WriteLine($"Does Anton I. work in the firm :{firm.Includ("Anton I.")}");

        }

    }
}

