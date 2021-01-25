namespace TestTask.Helper
{
    using Abstractions;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Models;

    public static class LinqExtention
    {

        public static bool Includ(this Firm sourse, string fullName)
        {
            FieldInfo fieldInfo = typeof(Firm).GetField("list", BindingFlags.Instance | BindingFlags.NonPublic);
            var copyList = (List<Employee>)fieldInfo.GetValue(sourse);

            var list = new List<string>();
            foreach (var item in copyList)
            {
                list.Add(item.FullName);
            }
            // I used query syntax because List has the Method "Contains"
            // in this case we didn't use Linq
            return ((from n in list select n).Contains(fullName));
        }

    }
}
