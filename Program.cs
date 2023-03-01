using System;
  
         Console.WriteLine("Guess the secret number!");
        
        string NumberGuess = AsksForGuess("What is the secret number? "); 
        Console.WriteLine(NumberGuess);
        string AsksForGuess(string question)
            {
                Console.Write($"{question}");
                int secretNumber = 42;
                string answer = Console.ReadLine().ToLower();
                bool isNumber = int.TryParse(answer, out int parsedAnswer);
                while (isNumber != true)
                    {
                        Console.Write($"{question}");
                        answer = Console.ReadLine().ToLower();
                        isNumber = int.TryParse(answer, out parsedAnswer);
                    }

                if (parsedAnswer == secretNumber)
                {
                    return "42 is the secret number!";
                }
                else {
                    return "That is the very wrong number!";
                }
                  

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
    
