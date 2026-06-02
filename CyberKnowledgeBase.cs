using System.Collections.Generic;

namespace CyberAwareAssistant
{
    public static class CyberKnowledgeBase
    {
        public class CyberTopic
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public string RiskLevel { get; set; }
        }

        public static Dictionary<int, CyberTopic> Topics = new()
        {
            {
                1,
                new CyberTopic
                {
                    Title = "Phishing",
                    Description = "Attackers trick users into revealing sensitive information such as passwords or bank details through fake emails or websites.",
                    Category = "Email Security",
                    RiskLevel = "High"
                }
            },
            {
                2,
                new CyberTopic
                {
                    Title = "Ransomware",
                    Description = "Malware that encrypts files and demands payment for decryption.",
                    Category = "Malware",
                    RiskLevel = "Critical"
                }
            },
            {
                3,
                new CyberTopic
                {
                    Title = "Multi-Factor Authentication (MFA)",
                    Description = "Adds an extra layer of security requiring multiple verification methods.",
                    Category = "Authentication",
                    RiskLevel = "High"
                }
            },
            {
                4,
                new CyberTopic
                {
                    Title = "Social Engineering",
                    Description = "Manipulating people into revealing confidential information.",
                    Category = "Human Threats",
                    RiskLevel = "High"
                }
            },
            {
                5,
                new CyberTopic
                {
                    Title = "Zero Trust",
                    Description = "Security model that assumes no user or system is trusted by default.",
                    Category = "Security Architecture",
                    RiskLevel = "High"
                }
            },
            {
                6,
                new CyberTopic
                {
                    Title = "VPN",
                    Description = "Encrypts internet traffic to secure communication over networks.",
                    Category = "Network Security",
                    RiskLevel = "Medium"
                }
            },
            {
                7,
                new CyberTopic
                {
                    Title = "Firewalls",
                    Description = "Monitors and controls incoming and outgoing network traffic.",
                    Category = "Network Security",
                    RiskLevel = "High"
                }
            },
            {
                8,
                new CyberTopic
                {
                    Title = "SIEM",
                    Description = "Security system that collects and analyzes logs from multiple sources.",
                    Category = "SOC Tools",
                    RiskLevel = "High"
                }
            },
            {
                9,
                new CyberTopic
                {
                    Title = "EDR",
                    Description = "Endpoint Detection and Response system for monitoring and investigating threats.",
                    Category = "SOC Tools",
                    RiskLevel = "High"
                }
            }
        };
    }
}