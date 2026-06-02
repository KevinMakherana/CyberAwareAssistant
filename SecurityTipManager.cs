using System;

namespace CyberAwareAssistant
{
    public static class SecurityTipManager
    {
        private static readonly string[] Tips =
        {
            "Use Multi-Factor Authentication (MFA) on all accounts.",
            "Never reuse passwords across different systems.",
            "Report phishing emails immediately to your SOC team.",
            "Keep your operating system and software updated.",
            "Avoid clicking on unknown or suspicious links.",
            "Do not plug in unknown USB devices.",
            "Use secure Wi-Fi networks for sensitive work.",
            "Lock your workstation when stepping away."
        };

        private static readonly Random random = new Random();

        public static void ShowTip()
        {
            Console.Clear();

            Console.WriteLine("==================================");
            Console.WriteLine("        SECURITY AWARENESS TIP");
            Console.WriteLine("==================================\n");

            string tip = Tips[random.Next(Tips.Length)];

            Console.WriteLine($"TIP: {tip}");

            ChatLogger.Log($"Security tip displayed: {tip}");

            Console.WriteLine("\n==================================");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}