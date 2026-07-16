using System;

namespace CyberAwareAssistant
{
    public static class QuizManager
    {
        private class Question
        {
            public string Text { get; set; }
            public string[] Options { get; set; }
            public int CorrectIndex { get; set; }
            public string Explanation { get; set; }
        }

        private static readonly Question[] Questions =
        {
            new Question
            {
                Text = "What should you do if you receive a suspicious email asking for your password?",
                Options = new[]
                {
                    "Send your password",
                    "Ignore security policy",
                    "Verify the sender before responding",
                    "Share it with colleagues"
                },
                CorrectIndex = 2,
                Explanation = "Always verify sender identity before taking action. This helps prevent phishing attacks."
            },
            new Question
            {
                Text = "What does MFA stand for?",
                Options = new[]
                {
                    "Multi-Factor Authentication",
                    "Main Firewall Access",
                    "Managed File Allocation",
                    "Multiple File Access"
                },
                CorrectIndex = 0,
                Explanation = "MFA adds an extra layer of security beyond just a password."
            },
            new Question
            {
                Text = "What is phishing?",
                Options = new[]
                {
                    "A network firewall system",
                    "A method of tricking users into revealing sensitive data",
                    "A type of antivirus software",
                    "A secure login method"
                },
                CorrectIndex = 1,
                Explanation = "Phishing is a social engineering attack that tricks users into giving sensitive information."
            },
            new Question
            {
                Text = "What is the main purpose of a firewall?",
                Options = new[]
                {
                    "To speed up internet connection",
                    "To block unauthorized network access",
                    "To store passwords",
                    "To clean viruses manually"
                },
                CorrectIndex = 1,
                Explanation = "Firewalls control incoming and outgoing network traffic based on security rules."
            },
            new Question
            {
                Text = "What does a VPN do?",
                Options = new[]
                {
                    "Deletes viruses automatically",
                    "Encrypts internet traffic for privacy",
                    "Blocks all websites",
                    "Speeds up gaming performance"
                },
                CorrectIndex = 1,
                Explanation = "A VPN encrypts your internet connection to protect your data online."
            }
        };

        public static void StartQuiz()
        {
            Console.Clear();

            Console.WriteLine("===================================");
            Console.WriteLine("       CYBERSECURITY QUIZ");
            Console.WriteLine("===================================\n");

            int score = 0;

            ProgressTracker.QuizAttempts++;

            for (int i = 0; i < Questions.Length; i++)
            {
                var q = Questions[i];

                Console.WriteLine($"Q{i + 1}: {q.Text}\n");

                for (int j = 0; j < q.Options.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {q.Options[j]}");
                }

                Console.Write("\nYour answer (1-4): ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int answer))
                {
                    Console.WriteLine("Invalid input. Moving to next question.\n");
                    continue;
                }

                if (answer - 1 == q.CorrectIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    Console.ResetColor();

                    score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect.");
                    Console.ResetColor();
                }

                Console.WriteLine($"Explanation: {q.Explanation}\n");
                Console.WriteLine("-----------------------------------\n");
            }

            int finalScore = (int)((double)score / Questions.Length * 100);

            Console.WriteLine("===================================");
            Console.WriteLine($"FINAL SCORE: {finalScore}%");
            Console.WriteLine("===================================\n");

            if (finalScore > ProgressTracker.HighestScore)
            {
                ProgressTracker.HighestScore = finalScore;
            }

            ChatLogger.Log($"Quiz completed | Score: {finalScore}%");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}