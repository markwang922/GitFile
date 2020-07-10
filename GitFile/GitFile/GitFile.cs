using System;
using System.IO;

namespace GitFileNS
{
    class GitFile
    {
        public void FileWrite(FileStream f)
        {
            for (int i=1; i <=20; i++)
            {
                f.WriteByte((byte)i);
            }
        }

        public void FileRead(FileStream f)
        {
            for (int i=0; i <=20; i++)
            {
                Console.Write(f.ReadByte() + "-> ");
            }
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("test2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            GitFile gTest = new GitFile();

            gTest.FileWrite(f);
            f.Position = 0;
            gTest.FileRead(f);

            f.Close();

            Console.ReadKey();
        }
    }
}
