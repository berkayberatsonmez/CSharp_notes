namespace ReverseName
{
    class Program
    {
        public static void Main(string[] args)
        {
            var nameList = new List<string>();
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            try
            {
                foreach (var i in name)
                {
                    nameList.Add(i.ToString());
                }
                nameList.Reverse();
                string result = string.Join("", nameList);
                Console.WriteLine(result);
            }
            catch 
            {
                Console.WriteLine("Enter just a name!");
            }

        }
    }
}