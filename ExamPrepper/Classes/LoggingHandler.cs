using ExamPrepper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrepper.Classes
{
    internal class LoggingHandler
    {
        private static string logFilePath = Settings.Default.LogFile_Path;
        private static string currentLogFile;

        public static bool LogFileExists() {
            if (!Directory.Exists(logFilePath)) Directory.CreateDirectory(logFilePath);
            currentLogFile = $"{logFilePath}/Log_{DateTime.Now.ToString("dd_MM_yyyy")}.log";
            if (!File.Exists(currentLogFile))
            {
                //File.Create(currentLogFile);
                File.AppendAllLines(currentLogFile, new List<string>
                {
                    "LOG FILE FOR " + DateTime.Now.ToString("dd/MM/yyyy"),
                    "===================================================",
                    "  Logging started",
                    "==================================================="
                });
            }
            return true;
        }

        public static void Log(string logText, bool newLog = false)
        {
            if (newLog)
            {
                WriteLog("================");
                WriteLog("   New Session  ");
                WriteLog("================");
            }
            logText = $"{DateTime.Now.ToString("yy/MM/dd_hh:mm:ss")} - {logText}";
            WriteLog(logText);
        }

        public static void Log(List<string> logText)
        {
            for (int i = 0; i < logText.Count; i++)
            {
                logText[i] = $"{DateTime.Now.ToString("yy/MM/dd_hh:mm:ss")} - {logText[i]}" + Environment.NewLine;
            }
            WriteLog(logText);
        }

        public static void WriteLog(string line)
        {
            LogFileExists();
            File.AppendAllText(currentLogFile, line + Environment.NewLine);
        }

        public static void WriteLog(List<string> lines)
        {
            LogFileExists();
            File.AppendAllLines(currentLogFile, lines);
        }

    }
}
