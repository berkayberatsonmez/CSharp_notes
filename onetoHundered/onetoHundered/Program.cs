namespace onetoHundered
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) 
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}