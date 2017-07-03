using System;
using System.Reflection;
using System.Runtime.InteropServices;
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
            var fileName = GetFileName();
            var filePath = System.IO.Path.Combine(path, $"{fileName}.csv");
            System.IO.File.WriteAllText(filePath, sb.ToString());
        }

        static string GetFileName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return "Win";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return "OSX";

            return "Linux";
        }
    }
}
