namespace Exercise13
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the width of the image");
                int width = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the image");
                int height = int.Parse(Console.ReadLine());

                if (width > height)
                {
                    Console.WriteLine("The image is in landscape orientation.");
                }
                else if (height > width)
                {
                    Console.WriteLine("The image is in portrait orientation.");
                }
                else
                {
                    Console.WriteLine("The image is square.");
                }
            }
            catch
            {

            }
        }
    }
}