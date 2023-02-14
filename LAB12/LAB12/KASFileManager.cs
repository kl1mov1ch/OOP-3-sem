using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace LAB12
{

    public static class KASFileManager
    {
        public static void InspectDriver(string driverName)
        {
            Directory.CreateDirectory(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASInspect");
            File.Create(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASDieInfo").Close();
            var currentDrive = DriveInfo.GetDrives().Single(x => x.Name == driverName);

            using (StreamWriter file = new StreamWriter(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASDirInfo.txt"))
            {
                file.WriteLine("Список папок:");
                foreach (var s in currentDrive.RootDirectory.GetDirectories())
                {
                    file.WriteLine(s);
                }
                file.WriteLine("Список файлов:");
                foreach (var f in currentDrive.RootDirectory.GetFiles())
                {
                    file.WriteLine(f);
                }
            }

            File.Copy(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASDirInfo.txt", @"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASDirInfoCopy", true);
            File.Delete(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\DirInfo.txt");
        }

        public static void CopyFiles(string path, string extention)
        {
            Directory.CreateDirectory(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASFile\");
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo directory2 = new DirectoryInfo(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASFile");
            foreach (var f in directory.GetFiles())
            {
                if (f.Extension == extention)
                    f.CopyTo(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASFile" + f.Name + extention, true);
            }
            if (!directory2.Exists)
                Directory.Move(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASFile", @"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASInspect\KASFile");
            else
                Directory.Delete(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASFile", true);
        }

        public static void CreateArchive(string dir)
        {
            string name = @"D:\БGTУ\3 сем\ООП\LAB12\LAB12";
            if (new DirectoryInfo(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12").GetFiles("*.zip").Length == 0)
            {
                ZipFile.CreateFromDirectory(name, name + ".zip");
                DirectoryInfo direct = new DirectoryInfo(dir);
                foreach (var innerFile in direct.GetFiles())
                    innerFile.Delete();
                direct.Delete();
                ZipFile.ExtractToDirectory(name + ".zip", dir);
            }
        }
    }
}
