namespace TestTask.Models
{
    using Abstractions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Helper;

    public class Firm
    {
        private List<Employee> list = new List<Employee>();

        public static Firm operator +(Firm firm, Employee item)
        {
            firm.list.Add(item);
            return firm;
        }

        public static Firm operator -(Firm firm, Employee item)
        {
            firm.list.Remove(item);
            return firm;
        }

        public List<TEmployee> GetEmployee<TEmployee>()
            where TEmployee : Employee
        {
            var newList = new List<TEmployee>();

            foreach (var item in this.list)
            {
                if (item is TEmployee)
                {
                    newList.Add(item as TEmployee);
                }
            }

            return newList;
        }

        public int CountOfEmployee<TEmployee>()
            where TEmployee : Employee
        {
            int count = 0;

            foreach (var item in this.list)
            {
                if (item is TEmployee)
                {
                    count++;
                }
            }

            return count;
        }

        public void Print()
        {
            this.list.Print();
        }

        public bool Incude(string fullName)
        {
            return list.Includ(fullName);
        }
    }
}
