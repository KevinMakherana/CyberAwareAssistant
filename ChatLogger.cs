using System;
using System.IO;

namespace CyberAwareAssistant
{
    public static class ChatLogger
    {
        private static readonly string LogFilePath = "logs.txt";

        public static void Log(string message)
        {
            try
            {
                string logEntry =
                    $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";

                File.AppendAllText(LogFilePath, logEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Logging failed: " + ex.Message);
                Console.ResetColor();
            }
        }
    }
}