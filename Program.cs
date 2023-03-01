using System;
  
         Console.WriteLine("Guess the secret number!");
        
        int NumberGuess = AsksForGuess("What is the secret number? "); 
        Console.WriteLine(NumberGuess);
        
        int AsksForGuess(string question)
            {
                Console.Write($"{question}");
                string answer = Console.ReadLine().ToLower();
                bool isNumber = int.TryParse(answer, out int parsedAnswer);
                while (isNumber != true)
                    {
                        Console.Write($"{question}");
                        answer = Console.ReadLine().ToLower();
                        isNumber = int.TryParse(answer, out parsedAnswer);
                    }

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
    
