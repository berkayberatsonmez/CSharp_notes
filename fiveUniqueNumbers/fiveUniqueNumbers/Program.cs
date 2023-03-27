namespace fiveUniqueNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numberList = new List<int>();
            Console.WriteLine("**Enter 5 number**");
            var i = 1;
            try
            {
                while(i < 6)
                {
                    Console.WriteLine("Enter {0}. number", i);
                    var number = int.Parse(Console.ReadLine());
                    if (numberList.Contains(number))
                    {
                        Console.WriteLine("This number have already entered. Enter new number please!");
                    }
                    else
                    {
                        numberList.Add(number);
                        i++;
                    }
                }
                numberList.Sort();
                Console.WriteLine("Sorted List:");
                foreach (var number in numberList)
                {
                    Console.WriteLine(number);
                }
            }
            catch 
            {
                Console.WriteLine("Enter just number");
            }


        }
    }
}