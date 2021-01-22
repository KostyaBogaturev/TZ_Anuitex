namespace TestTask.Models
{
    using Abstractions;
    using System;

    public class Foreman : Employee
    {
        public Foreman(string fullName, double experience)
            : base(fullName, experience, Enums.Position.Foremans)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Purchase of materials");
        }

        public void ValidationCheck()
        {
            Console.WriteLine("I have performed a validation check");
        }
    }
}