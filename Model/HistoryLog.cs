using System;
using System.IO;

namespace Homework_13.Model
{
    class HistoryLog
    {
        private const string path = "./historyLog.txt";

        public static void SaveLogFile(string message)
        {
            DateTime now = DateTime.Now;

            if (!File.Exists(path))
            {
                using (File.Create(path)) { }
            }

            File.AppendAllText(path, $"{now}: {message}\r\n");
        }
    }
}