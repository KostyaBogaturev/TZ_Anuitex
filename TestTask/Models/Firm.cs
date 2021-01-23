using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Models
{
    using Abstractions;
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
    }
}
