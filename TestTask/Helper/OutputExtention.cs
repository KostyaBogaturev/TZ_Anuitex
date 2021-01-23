namespace TestTask.Helper
{
    using Abstractions;
    using System;
    using System.Collections.Generic;

    public static class OutputExtention
    {
        public static void Print(this List<Employee> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
