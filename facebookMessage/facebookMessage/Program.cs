namespace facebookMessage
{
    class Program
    {
        public static void Main(string[] args)
        {
            var listOfName = new List<string>();
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter a name (or press Enter to quit):  ");
                    var input = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(input))
                    {
                        break;
                    }
                    else
                    {
                        listOfName.Add(input);
                    }
                }
                if (listOfName.Count == 0)
                {
                    Console.WriteLine(" ");
                }
                else if (listOfName.Count == 1)
                {
                    Console.WriteLine("{0} likes your post.", listOfName[0]);
                }
                else if (listOfName.Count == 2)
                {
                    Console.WriteLine("{0} and {1} like your post.", listOfName[0], listOfName[1]);
                }
                else 
                {
                    Console.WriteLine("{0}, {1}, and +{2} others like your post.", listOfName[0], listOfName[1], (listOfName.Count - 2));
                }
                
            }
            catch 
            {
                Console.WriteLine("Enter just name");
            }
        }
    }
}