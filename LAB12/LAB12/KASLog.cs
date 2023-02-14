using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12
{
    public class KASLog
    {
        private static StreamWriter logfile;
        private static string pathLog = @"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASLog.txt";
        public static void WriteInLog(string action, string fileName = "", string path = "")
        {
            if (fileName.Length != 0 || pathLog.Length != 0)
            {
                using (logfile = new StreamWriter(pathLog, true))
                {
                    logfile.WriteLine($"Действие: {action}");
                    logfile.WriteLine($"Имя файла: {fileName}");
                    logfile.WriteLine($"{DateTime.Now.ToString()}");
                    logfile.WriteLine($"Путь к файлу: {path}");
                    logfile.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                }
                using (logfile = new StreamWriter(pathLog, true))
                {
                    logfile.WriteLine($"{DateTime.Now.ToString()}");
                    logfile.WriteLine($"Действие: {action}");
                    logfile.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                }
            }
        }

        /*6. Найдите и выведите сохраненную информацию в файле xxxlogfile.txt о действиях пользователя за определенный день/ 
           * диапазон времени/по ключевому слову. Посчитайте количество записей в нем. Удалите часть информации, 
           * оставьте только записи за текущий час.*/
        public static void LogInfo()
        {
            var output = new StringBuilder();

            using (var stream = new StreamReader(pathLog))
            {
                var textline = "";
                var isActual = false;
                while (!stream.EndOfStream)
                {
                    isActual = false;
                    textline = stream.ReadLine();


                    isActual = true;
                    textline += Environment.NewLine;
                    output.AppendFormat(textline);


                    textline = stream.ReadLine();
                    while (textline != "▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬")
                    {
                        if (isActual)
                        {
                            textline += Environment.NewLine;
                            output.AppendFormat(textline);
                        }

                        textline = stream.ReadLine();
                    }

                    if (isActual)
                    {
                        output.AppendFormat("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                        output.AppendFormat(Environment.NewLine);
                    }
                }
            }

            using (var stream = new StreamWriter(@"D:\БGTУ\3 сем\ООП\LAB12\LAB12\KASLog.txt"))
            {
                stream.WriteLine(output.ToString());
            }

        }
        public static void PathClass()
        {
            string path2 = @"D:\БGTУ\3 сем\ООП\LAB12\LAB12";
            if (!Path.HasExtension(path2))
            {
                Console.WriteLine(path2);
            }
            if (!Path.IsPathRooted(path2))
            {
                Console.WriteLine(path2);

            }
        }
    }
}
