using System;
using System.IO;

namespace DirectoryListing
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            foreach (string filePath in Directory.GetFiles(folder)) 
            {
                FileInfo fileInfo = new FileInfo(filePath);
                Console.WriteLine($"File {fileInfo.Name} was created at {fileInfo.CreationTime}.");
                Console.WriteLine($"The file is {Math.Floor((DateTime.Now - fileInfo.CreationTime).TotalDays)} days old.");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("_______________________________________________________________________________________________");
            Console.WriteLine();
            long divider = 1024 * 1024 * 1024;
            foreach(string sDrive in Environment.GetLogicalDrives())
            {
                DriveInfo drive = new DriveInfo(sDrive);
                Console.WriteLine($"Drive {drive.Name} has {drive.TotalFreeSpace/divider:N0} GB of {drive.TotalSize/divider:N0} GB free.");
                Console.WriteLine($"Drive type is {drive.DriveType} and the format is {drive.DriveFormat}.");
                Console.WriteLine();
            }
        }
    }
}
