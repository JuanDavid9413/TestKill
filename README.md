using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestDataFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            List<string> vList = new List<string>();
            using (StreamReader vStream = new StreamReader(@"D:\JuanDavidMoreno\TestProjects\TestDataFile\Prueba.txt"))
            {
                while ((line = vStream.ReadLine()) != null)
                {
                    vList.Add(line);
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}
