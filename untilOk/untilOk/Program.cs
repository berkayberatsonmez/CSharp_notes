namespace untilOk
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number");
                    string value = Console.ReadLine();
                    if (value.ToLower() == "ok")
                    {
                        break;
                    }
                    else
                    {
                       sum += Convert.ToInt32(value);
                    }
                }
                catch 
                {
                    Console.WriteLine("Enter just number");
                }
            }
            Console.WriteLine(sum);
        }
    }
}