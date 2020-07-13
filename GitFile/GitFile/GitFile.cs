using System;
using System.IO;

namespace GitFileNS
{
    /*
    class GitFile
    {
        
        public static void Main(string[] args)
        {
            // create an instance of directory info
            DirectoryInfo di = new DirectoryInfo(@"C:/repos/Test");
            Console.WriteLine("Here is {0}", di.FullName);

            FileInfo[] fi = di.GetFiles();
            // show the file info under directory
            foreach (FileInfo f in fi)
            {
                Console.WriteLine("Here is {0} with {1} bytes.", f.Name, f.Length);
            }

            Console.WriteLine("============ This is a break line ==================");

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

            Console.WriteLine("============ This is a break line ==================");

            // test of using BinaryReader/BinaryWriter
            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am happy";

            BinaryWriter bsw;
            BinaryReader bsr;

            // create file
            try
            {
                bsw = new BinaryWriter(new FileStream("SampleBinary", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create the file.");
                return;
            }

            // write into file
            try
            {
                bsw.Write(i);
                bsw.Write(d);
                bsw.Write(b);
                bsw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
            bsw.Close();

            // read from file
            try
            {
                bsr = new BinaryReader(new FileStream("SampleBinary", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }

            // read and show file stream contents
            try
            {
                i = bsr.ReadInt32();
                Console.WriteLine("Integer data: {0}", i);
                d = bsr.ReadDouble();
                Console.WriteLine("Double data: {0}", d);
                b = bsr.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                s = bsr.ReadString();
                Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            bsr.Close();
            Console.ReadKey();
        }
    }
    */
    class MyAttribute
    {
        [Obsolete("Don't use NewMethod, use OldMethod instead", true)]

        static void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }

        static void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }
        
        public static void Main()
        {
            OldMethod();
            Console.ReadKey();
        }
    }
}
