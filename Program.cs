using System;
using System.Reflection;
using System.Text;

namespace NetCoreSpecialFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Environment.SpecialFolder sf in Enum.GetValues(typeof(System.Environment.SpecialFolder)))
            {
                sb.AppendLine($"{sf.ToString()}, {Environment.GetFolderPath(sf)}");
            }
            var path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().FullName);
            var filename = System.IO.Path.Combine(path, "macOut.csv");
            System.IO.File.WriteAllText(filename, sb.ToString());
        }
    }
}
