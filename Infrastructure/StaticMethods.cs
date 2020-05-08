using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace SQL_Multi_Flow.Infrastructure
{
    public static class StaticMethods
    {
        public static IEnumerable<string> getFilesNames(string pathToFolder, string extension = "*.sql")
        {
            DirectoryInfo directory = new DirectoryInfo(pathToFolder);
            var filesNames = new List<string>();

            foreach (var i in directory.GetFiles(extension))
            {
                filesNames.Add(i.FullName);
            }

            return filesNames.ToArray();
        }
    }
}
