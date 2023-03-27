using System;
namespace GuessNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            int number = random.Next(1,10);
            int lives = 3;
            try
            {
                Console.WriteLine("Try to guess number(don't forget you have 4 lives for the guess number)");
                for (var i = 0; i < 4;  i++)
                {
                    int guess = int.Parse(Console.ReadLine());
                    if (guess == number)
                    {
                        Console.WriteLine("Congratulations You won!");
                        break;
                    }
                    else if (lives == 0)
                    {
                        Console.WriteLine("Sorry You lose!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again You have {0} lives",lives);
                        lives--;
                    }
                    
                }

                
            }
            catch 
            {
                Console.WriteLine("Enter just number");
            }
        }
    }
}