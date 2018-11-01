using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryProject
{
    class Program
    {
        public static IEnumerable<string> listA { get; private set; }

        public static void Main(string[] args)
        {

            Console.WriteLine("Greetings and Welcome to the Dakar Academy Library");

            try
            {

                Int16 line_index = 0;
                using (var reader = new StreamReader(@"d:\BookList.csv"))
                {
                    List<string> listA = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        Console.WriteLine(line);
                        listA.Add(values[line_index]);
  //                    listB.Add(values[1]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            foreach (string line in listA)
            {
                Console.WriteLine(line);
            }
        }
    }
}


