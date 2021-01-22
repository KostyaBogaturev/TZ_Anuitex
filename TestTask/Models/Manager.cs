namespace TestTask.Models
{
    using Abstractions;
    using System;

    public class Manager : Employee
    {
        public Manager(string fullName, double experience)
            : base(fullName, experience, Enums.Position.Managers)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Taking orders");
        }

        public void GiveTask()
        {
            Console.WriteLine("I issued a task");
        }
    }
}