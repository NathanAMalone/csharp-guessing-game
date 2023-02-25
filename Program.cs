using System;
  
         Console.WriteLine("Guess the secret number!");
        
        int NumberGuess = AsksForGuess("What is the secret number? "); 
        Console.WriteLine(NumberGuess);
        
        int AsksForGuess(string question)
            {
                Console.Write($"{question}");
                string answer = Console.ReadLine().ToLower();
                int parsedAnswer = int.Parse(answer);

                return parsedAnswer;

                // while (answer != "y" && answer != "n")
                // {
                //     Console.Write($"{question} (Y/N): ");
                //     answer = Console.ReadLine().ToLower();
                // }

                // if (answer == "y")
                // {
                //     return true;
                // }
                // else
                // {
                //     return false;
                // }
            }
    
