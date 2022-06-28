using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@£$%^&*~";

            Console.WriteLine("Please enter a password: ");
            string password = Console.ReadLine();

            int score = 0;

            if (password.Length >= minLength) {
                score ++;
            }
            if (Tools.Contains(password, uppercase)) {
                score ++;
            }
            if (Tools.Contains(password, lowercase)) {
                score ++;
            }
            if (Tools.Contains(password, digits)) {
                score ++;
            }
            if (Tools.Contains(password, specialChars)) {
                score ++;
            }

            if (password == "password" || password == "1234") {
                score = 0;
                Console.WriteLine($"Password cannot be '{password}'.");
            }

            switch (score) {
                case >= 4:
                    Console.WriteLine($"Password score: {score}");
                    Console.WriteLine("Extremely strong password - you're a password whizz!");
                    break;
                case 3:
                    Console.WriteLine($"Password score: {score}");
                    Console.WriteLine("Strong password.");
                    break;
                case 2:
                    Console.WriteLine($"Password score: {score}");
                    Console.WriteLine("Medium strength password.");
                    break;
                case 1:
                    Console.WriteLine($"Password score: {score}");
                    Console.WriteLine("Weak password.");
                    break;
                default:
                    Console.WriteLine($"Password score: {score}");
                    Console.WriteLine("Your password does not meet the minimum requirements.");
                    break;
            }
    }
  }
}