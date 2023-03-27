namespace maxOfArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("enter a series of numbers separated by comma:");
                var input = Console.ReadLine();
                string[] numbers = input.Split(',');
                int maxNumber = int.Parse(numbers[0]);
                for (var i = 1;  i < numbers.Length; i++)
                {
                    if (maxNumber < int.Parse(numbers[i]))
                    {
                        maxNumber = int.Parse(numbers[i]);
                    }
                }
                Console.WriteLine(maxNumber);

            }
            catch 
            {
                Console.WriteLine("Enter just number or spearate by comma.");
            }


        }
    }
}