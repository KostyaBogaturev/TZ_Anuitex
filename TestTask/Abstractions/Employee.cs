namespace TestTask.Abstractions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Employee
    {
        private readonly string fullName;

        public string FullName { get => this.fullName; }
        public double Еxperience { get; set; }

        public Employee(string fullName, double experience)
        {
            this.fullName = fullName;
            Еxperience = experience;
        }

        public abstract void Work();

    }
}
