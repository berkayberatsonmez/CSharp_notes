namespace uniqueItems
{
    class Program
    {
        public static void Main(string[] args) 
        { 
            var numbersList = new List<int>();
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter a number or quit for enter quit");
                    var input = Console.ReadLine();
                    if (input.ToLower() == "quit")
                    {
                        break;
                    }
                    else
                    {
                        var number = Convert.ToInt32(input);
                        numbersList.Add(number);
                    }
                }
                var newlist = numbersList.Distinct();
                foreach (var number in newlist)
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