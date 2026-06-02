using System;

namespace CyberAwareAssistant
{
    public static class CyberTopicManager
    {
        public static void ShowTopics()
        {
            Console.Clear();

            Console.WriteLine("=========== CYBERSECURITY TOPICS ===========\n");

            foreach (var topic in CyberKnowledgeBase.Topics)
            {
                Console.WriteLine($"{topic.Key}. {topic.Value.Title} ({topic.Value.RiskLevel})");
            }

            Console.Write("\nSelect topic number: ");

            if (!int.TryParse(Console.ReadLine(), out int choice) ||
                !CyberKnowledgeBase.Topics.ContainsKey(choice))
            {
                Console.WriteLine("Invalid selection.");
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                return;
            }

            var selected = CyberKnowledgeBase.Topics[choice];

            Console.Clear();

            Console.WriteLine("=====================================");
            Console.WriteLine($"TITLE      : {selected.Title}");
            Console.WriteLine($"CATEGORY   : {selected.Category}");
            Console.WriteLine($"RISK LEVEL : {selected.RiskLevel}");
            Console.WriteLine("=====================================\n");

            Console.WriteLine(selected.Description);

            ProgressTracker.TopicsViewed++;
            ChatLogger.Log($"Viewed topic: {selected.Title}");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public static void ShowSOC()
        {
            Console.Clear();

            Console.WriteLine("=========== SOC ANALYST TRAINING ===========\n");

            Console.WriteLine("SIEM (Security Information and Event Management)");
            Console.WriteLine("- Collects and analyzes security logs from systems.\n");

            Console.WriteLine("EDR (Endpoint Detection and Response)");
            Console.WriteLine("- Detects and responds to threats on endpoints.\n");

            Console.WriteLine("Threat Hunting");
            Console.WriteLine("- Proactive search for hidden threats.\n");

            Console.WriteLine("Incident Response");
            Console.WriteLine("- Structured handling of security incidents.\n");

            Console.WriteLine("MITRE ATT&CK");
            Console.WriteLine("- Framework for attacker behavior analysis.\n");

            Console.WriteLine("============================================");

            ChatLogger.Log("Viewed SOC Training");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}