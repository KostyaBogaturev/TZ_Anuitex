namespace TestTask.Abstractions
{
    using Enums;

    public abstract class Employee
    {
        protected readonly Position position;
        private readonly string fullName;

        public string FullName { get => this.fullName; }
        public double Еxperience { get; set; }

        public Employee(string fullName, double experience, Position position)
        {
            this.fullName = fullName;
            Еxperience = experience;
            this.position = position;
        }

        public abstract void Work();

    }
}
