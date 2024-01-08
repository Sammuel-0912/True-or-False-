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
      string[] questions = {"1: True or false – the five rings on the Olympic flag are interlocking?", "2: True or false – Mount Kilimanjaro is the highest mountain in the world?", "3: True or false – a group of swans is known as a bevy?", "4: True or false – Sydney is the capital of Australia?", "5: True or false – fish cannot blink?"} ; 
      bool[] answers = {true, false, true, false, true};
      bool[] responses = new bool[5] ; 
      if(questions.Length != answers.Length)
      {
          Console.WriteLine("Warning! x doesn't equal y");
      }
      int askingIndex = 0 ; 
      foreach(string question in questions)
      {
          string input; 
          bool isBool ; 
          bool inputBool ; 
          Console.WriteLine(question) ; 
          Console.WriteLine("True or False") ;
          input = Console.ReadLine() ; 
          isBool = Boolean.TryParse(input, out inputBool ) ; 
          while (!isBool)
          {
             Console.WriteLine("Please respond with 'true' or 'false'.");
             input = Console.ReadLine() ; 
             isBool = Boolean.TryParse(input, out inputBool);
          }
          responses[askingIndex]  = isBool ; 
          askingIndex++ ; 
      }
      int scoringIndex = 0 ; 
      int score = 0 ; 
      foreach(bool answer in answers)
      {
          bool response = responses[scoringIndex] ; 
          Console.Write(scoringIndex + 1 + " ") ; 
          Console.WriteLine($"Input: {response} | Answer: {answer}");
          if(response == answer)
          {
              score++ ; 
          }
          scoringIndex++ ; 
      }
      Console.WriteLine($"You got {score} out of {questions.Length} Correct");
    }
  }
}
