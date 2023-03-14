using System;
  
        Console.WriteLine("Guess the secret number!");
        
        string NumberGuess = AsksForGuess("What is the secret number? "); 
        Console.WriteLine(NumberGuess);
        string AsksForGuess(string question)
            {
                
                    Console.Write($"{question} Guess (1) of (4): ");
                    Random randomNumber = new Random();
                    int secretNumber = randomNumber.Next(1, 100);
                    string answer = Console.ReadLine().ToLower();
                    bool isNumber = int.TryParse(answer, out int parsedAnswer);
                
                for (int i = 0; i < 3; i++)
                    {
                        if (isNumber != true)
                            {
                                Console.WriteLine("That is not a number!");
                                Console.Write($"{question} Guess ({i + 2}) of (4): ");
                                answer = Console.ReadLine().ToLower();
                                isNumber = int.TryParse(answer, out parsedAnswer);
                            }
                        else {
                        if (isNumber == true && parsedAnswer != secretNumber)
                            {
                                Console.WriteLine("That is the very wrong number!");
                                Console.Write($"{question} Guess ({i + 2}) of (4): ");
                                answer = Console.ReadLine().ToLower();
                                isNumber = int.TryParse(answer, out parsedAnswer);
                            }
                        }    
                    }
                    if (parsedAnswer == secretNumber)
                    {
                        return $"{secretNumber} is the secret number!";
                    }
                    else {
                        return $"That is the very wrong number, and you have no more guesses!\r\nThe secret number was {secretNumber}!!!";
                    }
            }