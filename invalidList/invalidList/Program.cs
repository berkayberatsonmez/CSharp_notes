using System.Collections.Generic;
namespace invalidList
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number list which separated by comma and list lenght not less than 5: ");
                var input = Console.ReadLine();
                var inputList = input.Split(',').ToList();
                if (inputList.Count < 5) 
                {
                    Console.WriteLine("Invalid List. Please Try again!");
                }
                else
                {
                    inputList.Sort();
                    for (var i = 0; i < 3; i++)
                    {
                        Console.WriteLine(inputList[i]);
                    }
                }
            }
            catch 
            {
                Console.WriteLine("Please, enter as requested.!");
            }

        }
    }
}