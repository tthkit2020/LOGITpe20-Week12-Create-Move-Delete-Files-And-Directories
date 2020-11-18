using System;
using System.IO;

namespace ClearFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\julia.voronetskaja\samples";
            DeleteAllfiles();

            DirectoryInfo rootDirectory = new DirectoryInfo(rootPath);
            foreach(DirectoryInfo dir in rootDirectory.GetDirectories())
            {
                DeleteAllfolders(dir.FullName, true);
            }

           
        }

        //a function to delete all the files
        public static void DeleteAllfiles()
        {
            string rootPath = @"C:\Users\julia.voronetskaja\samples";
            DirectoryInfo directory = new DirectoryInfo(rootPath);

            foreach(FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }
        }
        //a function to delete all the folders
        public static void DeleteAllfolders(string directoryName, bool ifExists)
        {
            if (Directory.Exists(directoryName))
            {
                Directory.Delete(directoryName, true);
            } else if (ifExists)
            {
                throw new SystemException("No such directory to delete");
            }
        }
    }
}
