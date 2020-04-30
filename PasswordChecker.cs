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
      string digits = "1234567890";
      string specialChars = "!@#$%&";

      Console.WriteLine("Enter the password you would like to check:");
      string password = Console.ReadLine();

      int score = 0;

      if (password.Length >= minLength)
      {
        score++;
      }
      if (Tools.Contains(password, uppercase))
      {
        score++;
      }
      if (Tools.Contains(password, lowercase))
      {
        score++;
      }
      if (Tools.Contains(password, digits))
      {
        score++;
      }
      if (Tools.Contains(password, specialChars))
      {
        score++;
      }
      switch (score)
      {
        case 5:
        case 4:
          Console.WriteLine("Your password strength is extremely strong!");
          break;
        case 3:
          Console.WriteLine("Your password strength is strong.");
          break;
        case 2:
          Console.WriteLine("Your password strength is medium.");
          break;
        case 1:
          Console.WriteLine("Your password strength is weak.");
          break;
        default:
          Console.WriteLine("Your password does not meet any of the requirements.");
          break;
      }
    }
  }
}
