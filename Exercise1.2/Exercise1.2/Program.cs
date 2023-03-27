namespace Exercise12
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number");
                string numberOne = Console.ReadLine();
                Console.WriteLine("Enter second number");
                string numberTwo = Console.ReadLine();
                int one = Convert.ToInt16(numberOne);
                int two = Convert.ToInt16(numberTwo);
                if (one > two)
                {
                    Console.WriteLine(one);
                }
                else
                {
                    Console.WriteLine(two);
                }
            }
            catch
            {
                Console.WriteLine("Enter just number");
            }
            }
            
        }
}

