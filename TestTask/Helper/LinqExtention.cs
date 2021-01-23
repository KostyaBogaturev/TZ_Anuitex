namespace TestTask.Helper
{
    using Abstractions;
    using System.Collections.Generic;
    using System.Linq;

    public static class LinqExtention
    {
        public static bool Includ(this List<Employee> sourse, string fullName)
        {
            var list = new List<string>();
            foreach (var item in sourse)
            {
                list.Add(item.FullName);
            }

            // I used query syntax because List has the Method "Contains"
            // in this case we didn't use Linq
            return ((from n in list select n).Contains(fullName));
        }
    }
}
