using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Creature Creator Program!");
      Console.WriteLine("Combine parts from ghosts, bugs, and monsters to create a creature!");
      Console.Write("Generate a random creature? (Y/N): ");
      string userChoice = Console.ReadLine();
      if (userChoice == "Y" || userChoice == "y")
      {
        RandomMode();
      }
      else
      {
        Console.Write("Select a head type: ");
        string userHead = Console.ReadLine();
        Console.Write("Select a body type: ");
        string userBody = Console.ReadLine();
        Console.Write("Select a feet type: ");
        string userFeet = Console.ReadLine();
        Console.WriteLine("Here is your creature!");
        BuildACreature(userHead, userBody, userFeet);
      }
    }
    static void BuildACreature(string head, string body, string feet)
    {
      int headNum = TranslateToNumber(head);
      int bodyNum = TranslateToNumber(body);
      int feetNum = TranslateToNumber(feet);
      SwitchCase(headNum, bodyNum, feetNum);
    }
    static void RandomMode()
    {
      Random randomNumber = new Random();
      int ranHead = randomNumber.Next(1, 4);
      int ranBody = randomNumber.Next(1, 4);
      int ranFeet = randomNumber.Next(1, 4);
      SwitchCase(ranHead, ranBody, ranFeet);
    }
    static void SwitchCase(int head, int body, int feet)
    {
      switch (head)
      {
        case 1:
          GhostHead();
          break;
        case 2:
          BugHead();
          break;
        case 3:
          MonsterHead();
          break;
        default:
          Console.WriteLine("Invalid head entry.");
          break;
      }
      switch (body)
      {
        case 1:
          GhostBody();
          break;
        case 2:
          BugBody();
          break;
        case 3:
          MonsterBody();
          break;
        default:
          Console.WriteLine("Invalid body entry.");
          break;
      }
      switch (feet)
      {
        case 1:
          GhostFeet();
          break;
        case 2:
          BugFeet();
          break;
        case 3:
          MonsterFeet();
          break;
        default:
          Console.WriteLine("Invalid feet entry.");
          break;
      }
    }
    static int TranslateToNumber(string creature)
    {
      switch (creature)
      {
        case "ghost":
          return 1;
          break;
        case "bug":
          return 2;
          break;
        case "monster":
          return 3;
          break;
        default:
          return 0;
          break;
      }
    }
    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
