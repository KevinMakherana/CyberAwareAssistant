# CyberAware Assistant 🛡️

CyberAware Assistant is a simple cybersecurity awareness and training tool built in C#.  
It’s designed to simulate basic SOC-style onboarding where users can learn cybersecurity concepts, take quizzes, and log security incidents.

I built this as a portfolio project to show my understanding of C#, OOP, and basic cybersecurity principles.

---

## What it does

The application runs in the console and lets a user:

- Learn basic cybersecurity topics like phishing, ransomware, MFA, etc.
- Take a short security quiz and get a score
- View random security tips
- Log simulated security incidents
- Track their progress over time

It also keeps a simple log file of actions during a session.

---

## Features

### Cybersecurity Topics
Basic explanations of common security concepts like:
- Phishing
- Ransomware
- Firewalls
- VPNs
- Social engineering

### Quiz System
- Multiple-choice questions
- Instant feedback after each answer
- Final score at the end of the quiz

### Incident Reporting
- Simulates reporting a suspicious email or activity
- Generates a simple ticket ID
- Includes severity selection

### Progress Tracking
- Tracks:
  - Topics viewed
  - Quiz attempts
  - Highest score
  - Incidents reported
- Gives a basic awareness level (Beginner → Advanced)

### Security Tips
- Random cybersecurity tips displayed each time

### Logging
- Saves basic activity logs to a text file (`logs.txt`)

---

## Tech Used

- C#
- .NET Console Application
- Object-Oriented Programming
- File handling (basic logging)
- Collections (lists, dictionaries)

---

## Why I built this

I wanted to create something that combines:
- Software development (C#)
- Cybersecurity awareness
- Basic SOC-style thinking

It’s not a full production system, but more of a learning and demonstration project.

---

## How to run it

1. Clone the repo
2. Open the solution in Visual Studio
3. Build the project
4. Run the program

---

## Notes

This project is still a work in progress.  
Future improvements could include a GUI version or database integration.

---

## Author

Kevin Makherana
