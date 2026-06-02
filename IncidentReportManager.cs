using System;

namespace CyberAwareAssistant
{
    public static class IncidentReportManager
    {
        public static void CreateReport()
        {
            Console.Clear();

            Console.WriteLine("========== INCIDENT REPORT SYSTEM ==========\n");

            Console.Write("Sender Email: ");
            string sender = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(sender))
            {
                Console.WriteLine("Invalid sender email.");
                Console.ReadKey();
                return;
            }

            Console.Write("Incident Description: ");
            string reason = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(reason))
            {
                Console.WriteLine("Incident description cannot be empty.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nSelect Severity:");
            Console.WriteLine("1. Low");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. High");
            Console.WriteLine("4. Critical");
            Console.Write("Choice: ");

            string severity = GetSeverity(Console.ReadLine());

            string id = GenerateTicketId();

            DateTime timestamp = DateTime.Now;

            Console.Clear();

            Console.WriteLine("=====================================");
            Console.WriteLine("        INCIDENT TICKET CREATED");
            Console.WriteLine("=====================================\n");

            Console.WriteLine($"Ticket ID   : {id}");
            Console.WriteLine($"Timestamp   : {timestamp}");
            Console.WriteLine($"Sender      : {sender}");
            Console.WriteLine($"Severity    : {severity}");
            Console.WriteLine($"Description : {reason}");
            Console.WriteLine("Status      : SUBMITTED");
            Console.WriteLine("Assigned To : SOC Team");
            Console.WriteLine("=====================================");

            ProgressTracker.IncidentsReported++;
            ChatLogger.Log($"Incident created {id} | Severity: {severity}");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private static string GetSeverity(string input)
        {
            return input switch
            {
                "1" => "Low",
                "2" => "Medium",
                "3" => "High",
                "4" => "Critical",
                _ => "Low"
            };
        }

        private static string GenerateTicketId()
        {
            return "INC-" + DateTime.Now.ToString("yyyy") +
                   "-" + new Random().Next(10000, 99999);
        }
    }
}