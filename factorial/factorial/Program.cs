namespace factorial
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number which you want to factorial");
            int number = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (var i = 1; i <= number; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);

        }
    }
}