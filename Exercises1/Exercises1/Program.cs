namespace Exercises1
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 to 10: ");

            try
            {
                string numberString = Console.ReadLine();
                int number = int.Parse(numberString);
                if (10 > number && number > 1)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            catch
            {
                Console.WriteLine("Enter just numbers");
            }
        }
    }
}