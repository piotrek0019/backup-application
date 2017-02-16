using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ProfHenryCopy
{
    class Program
    {
        static public void CopyDirectHenr1(string sourceDirectory, string destDirectory)
        {
            

            if (!Directory.Exists(destDirectory))
                Directory.CreateDirectory(destDirectory);

            string[] files = Directory.GetFiles(sourceDirectory);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destDirectory, name);
                File.Copy(file, dest);
            }
            string[] directories = Directory.GetDirectories(sourceDirectory);

            Console.WriteLine("Copy directory 1");

            foreach (string directory in directories)
            {
                string name = Path.GetFileName(direcotry);
                string dest = Path.Combine(destDirectory, name);
                CopyDirectHenr1(directory, dest);
            }
        }

        static public void CopyDirectHenr2(string sourceDirectory, string destDirectory)
    {
         

            if (!Directory.Exists(destDirectory))
                Directory.CreateDirectory(destDirectory);

            string[] files = Directory.GetFiles(sourceDirectory);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destDirectory, name);
                File.Copy(file, dest);
            }
            string[] directories = Directory.GetDirectories(sourceDirectory);

            Console.WriteLine("Copy directory 2");

            foreach (string directory in directories)
            {
                string name = Path.GetFileName(directory);
                string dest = Path.Combine(destDirectory, name);
                CopyDirectHenr2(directory, dest);
            }

    }
    
        static public void CopyFileHenry(string fileSource, string destFile)
        {
            string file = fileSource;
            Console.WriteLine("Copy file ...");
            string name = Path.GetFileName(file);
            string dest = Path.Combine(destFile, name);
            File.Copy(file, dest);
        }
 

        static public void CopyDirectory2(string sourceDirecotry, string destDirecotry, bool overwrite)
        {
         

            Directory.CreateDirectory(destDirecotry);

            string[] files = Directory.GetFiles(sourceDirecotry);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destDirecotry, name);
                File.Copy(file, dest, true);
            }
            string[] directories = Directory.GetDirectories(sourceDirecotry);
            
            Console.WriteLine("Copy directory 3");

            foreach (string directory in directories)
            {
                string name = Path.GetFileName(directory);
                string dest = Path.Combine(destDirecotry, name);
                CopyDirectory2(directory, dest, true);
            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmss"));
            string sourceDirectory = @"D:\Programy\path1\1";
            string sourceDirectory3 = @"D:\Programy\path2\db";
            string file = @"D:\Programy\path3\usr_v2.t";
            string destDirecotry = @"E:\OneDrive\path4\postępy_w_nauce_";
           
            string sourceDirectory2 = @"E:path5";
            string destDirecotry2 = @"E:\OneDrive\path6\Piotr_dok";

            string dataTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            destDirecotry += dataTime;
            try
            {
                Console.ReadLine();

                if (!Directory.Exists(destDirecotry))
                {
                    if (Directory.Exists(destDirecotry))
                    {
                        destDirecotry += 1;
                    }
                    Directory.CreateDirectory(destDirecotry);
                }



                CopyDirectHenr1(sourceDirectory, destDirecotry + @"\1");
                Console.WriteLine("Copy directory 1 finished");

                CopyDirectHenr2(sourceDirectory3, destDirecotry + @"\db");
                Console.WriteLine("Copy directory db finished");

                CopyFileHenry(file, destDirecotry);
                Console.WriteLine("Copy file usr_v2 finished");
            
                CopyDirectory2(sourceDirectory2, destDirecotry2, true);
                Console.WriteLine("Copy directory 3 finished");
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error: " + Ex.Message);
            }

            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }
    }
}
