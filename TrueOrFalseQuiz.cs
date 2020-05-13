using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = { "A tomato is a vegetable.", "Puerto Rico is part of the United States.", "A platypus is a mammal.", "The Earth is flat.", "Cats do not like having their bellies rubbed." };
      bool[] answers = { false, true, true, false, false };
      bool[] responses = new bool[questions.Length];
      if (questions.Length != answers.Length)
      {
        Console.WriteLine("WARNING: Mismatch in number of questions and answers!");
      }

      int askingIndex = 0;
      foreach (string question in questions)
      {
        string input;
        bool isBool = false;
        bool inputBool= false;
        Console.WriteLine(question);
        Console.WriteLine("True or False?");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);
        while (!isBool)
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }
        responses[askingIndex] = inputBool;
        askingIndex++;
      }
      foreach (bool response in responses)
      {
        Console.WriteLine(response);
      }
      
      int scoringIndex = 0;
      int score = 0;
      foreach (bool answer in answers)
      {
        bool response = responses[scoringIndex];
        Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");
        if (response == answer)
        {
          score++;
        }
        scoringIndex++;
      }
      Console.WriteLine($"You got {score} out of {questions.Length} correct!");
    }
  }
}
