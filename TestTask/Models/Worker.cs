namespace TestTask.Models
{
    using Abstractions;
    using System;

    public class Worker : Employee
    {
        public Worker(string fullName, double experience)
            : base(fullName, experience, Enums.Position.Workers)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Production output");
        }
    }
}
