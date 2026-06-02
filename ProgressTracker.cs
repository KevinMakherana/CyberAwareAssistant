using System;

namespace CyberAwareAssistant
{
    public static class ProgressTracker
    {
        public static int TopicsViewed = 0;
        public static int QuizAttempts = 0;
        public static int HighestScore = 0;
        public static int IncidentsReported = 0;

        public static void Show()
        {
            Console.Clear();

            int completion = CalculateCompletionScore();
            string level = GetAwarenessLevel(completion);

            Console.WriteLine("==========================================");
            Console.WriteLine("        CYBERAWARE TRAINING DASHBOARD");
            Console.WriteLine("==========================================\n");

            Console.WriteLine($"Topics Viewed          : {TopicsViewed}");
            Console.WriteLine($"Quiz Attempts         : {QuizAttempts}");
            Console.WriteLine($"Highest Quiz Score    : {HighestScore}%");
            Console.WriteLine($"Incidents Reported    : {IncidentsReported}");

            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine($"Training Completion   : {completion}%");
            Console.WriteLine($"Awareness Level       : {level}");
            Console.WriteLine("------------------------------------------\n");

            DisplayRecommendation(level);

            ChatLogger.Log("Viewed progress dashboard");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private static int CalculateCompletionScore()
        {
            // Weighted SOC-style scoring system
            int score = 0;

            score += TopicsViewed * 4;        // learning engagement
            score += QuizAttempts * 10;       // assessment participation
            score += IncidentsReported * 8;   // reporting awareness

            return Math.Min(score, 100);
        }

        private static string GetAwarenessLevel(int score)
        {
            if (score >= 85) return "Advanced SOC Awareness";
            if (score >= 60) return "Intermediate Security Awareness";
            if (score >= 35) return "Developing Awareness";
            return "Beginner Level";
        }

        private static void DisplayRecommendation(string level)
        {
            Console.WriteLine("RECOMMENDATION:\n");

            switch (level)
            {
                case "Advanced SOC Awareness":
                    Console.WriteLine("- Excellent performance.");
                    Console.WriteLine("- Consider advanced SOC simulations and threat hunting.");
                    break;

                case "Intermediate Security Awareness":
                    Console.WriteLine("- Good progress.");
                    Console.WriteLine("- Focus on phishing detection and incident response practice.");
                    break;

                case "Developing Awareness":
                    Console.WriteLine("- Keep learning fundamentals.");
                    Console.WriteLine("- Complete more quizzes and review SOC training modules.");
                    break;

                default:
                    Console.WriteLine("- Start with cybersecurity basics.");
                    Console.WriteLine("- Focus on phishing, passwords, and safe browsing.");
                    break;
            }
        }

        public static void UpdateQuizScore(int score)
        {
            if (score > HighestScore)
            {
                HighestScore = score;
            }
        }
    }
}