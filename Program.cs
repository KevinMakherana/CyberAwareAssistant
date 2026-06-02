using System;

namespace CyberAwareAssistant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CyberAware Assistant - SOC Training Platform";

            ShowBanner();

            Console.Write("Enter employee name: ");
            string user = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(user))
                user = "Employee";

            ChatLogger.Log($"Session started | User: {user}");

            bool running = true;

            while (running)
            {
                ShowMenu();

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input. Please select a menu option.");
                    continue;
                }

                switch (input.Trim())
                {
                    case "1":
                        CyberTopicManager.ShowTopics();
                        break;

                    case "2":
                        QuizManager.StartQuiz();
                        break;

                    case "3":
                        SecurityTipManager.ShowTip();
                        break;

                    case "4":
                        IncidentReportManager.CreateReport();
                        break;

                    case "5":
                        CyberTopicManager.ShowSOC();
                        break;

                    case "6":
                        ProgressTracker.Show();
                        break;

                    case "7":
                        ExitApplication(user);
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void ShowBanner()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=================================================");
            Console.WriteLine("         CYBERAWARE ASSISTANT v3.0");
            Console.WriteLine("  Cybersecurity Awareness Training Platform");
            Console.WriteLine("=================================================");
            Console.WriteLine("   SOC Training | Awareness | Incident Simulation");
            Console.WriteLine("=================================================");

            Console.ResetColor();
        }

        static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("============== MAIN MENU ==============");
            Console.WriteLine("1. Cybersecurity Topics");
            Console.WriteLine("2. Security Quiz");
            Console.WriteLine("3. Security Tips");
            Console.WriteLine("4. Report Incident");
            Console.WriteLine("5. SOC Training");
            Console.WriteLine("6. View Progress");
            Console.WriteLine("7. Exit");
            Console.WriteLine("=======================================");
            Console.Write("Select option: ");
        }

        static void ExitApplication(string user)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n=================================");
            Console.WriteLine("Session Ended");
            Console.WriteLine($"User: {user}");
            Console.WriteLine("Thank you for using CyberAware Assistant.");
            Console.WriteLine("Stay secure. Stay aware.");
            Console.WriteLine("=================================");

            Console.ResetColor();

            ChatLogger.Log($"Session ended | User: {user}");
        }
    }
}