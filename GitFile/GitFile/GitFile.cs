using System;
using System.IO;

namespace GitFileNS
{
    class GitFile
    {
        public static void Main(string[] args)
        {
            string[] names = new string[] { "Shelby Hegwood", "Bob Smith", "Canon Weathing", "Delta Kirby" };

            using (StreamWriter sw = new StreamWriter("C:/repos/Test/SampleNames.txt"))
            {
                foreach (string n in names)
                {
                    sw.WriteLine(n);
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader("C:/repos/Test/SampleNames.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file cannot be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
