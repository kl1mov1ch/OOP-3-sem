using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12
{
    internal class Program
    {
        static void Main(string[] args)
        {
        try
        {
            Console.WriteLine($"Свободное место на диске D: {KASDiskInfo.FreeDiskSpace("D")}");
            Console.WriteLine($"Формат диска D: {KASDiskInfo.DiskFormat("D")}");
            KASDiskInfo.InformationAboutDisk("D");
            KASLog.WriteInLog("KASDiskInfo");


            Console.WriteLine($"\nПолный путь к файлу KASlogfile.txt: {KASFileInfo.PrintFullPath(@"KASlogfile.txt")}");
            KASFileInfo.PrintSizeExtensionAndName(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASFileInfo.txt");
            KASLog.WriteInLog("KASiskInfo.InformationAboutDisk()", "KASlogfile.txt", @"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASFileInfo.txt");
            KASFileInfo.PrintDateOfCreation(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASFileInfo.txt");
            Console.WriteLine($"\nКол-во файлов в mare: {KASDirInfo.PrintNumberOfFiles(@"D:\more")}");
            KASDirInfo.TimeOfCreation(@"D:\more");
            Console.WriteLine($"Кол-во поддиректориев в директории more: {KASDirInfo.NumberOfSubDirectories(@"D:\more")}");
            KASDirInfo.ListOfParentDirectories(@"D:\БGTУ\3 сем\ООП\LAB12");
            KASFileManager.InspectDriver("D:\\");
            KASFileManager.CopyFiles(@"D:\more", ".docx");
            KASFileManager.CopyFiles(@"D:\more", ".docx");
            KASFileManager.CreateArchive(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\Arhive");
            KASLog.LogInfo();
            KASLog.PathClass();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        }
    }
}
