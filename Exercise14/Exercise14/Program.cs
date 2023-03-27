namespace Exercise14
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter speed limit");
                int speedLimit = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter speed of a car");
                int speedOfCar = int.Parse(Console.ReadLine());
                int demeritPoints = (speedOfCar - speedLimit) / 5;
                if (speedLimit > speedOfCar)
                {
                    Console.WriteLine("Ok.");
                }
                else if (demeritPoints > 12)
                {
                    Console.WriteLine("Your demerit points is {0}\nLicense Suspended.", demeritPoints);
                }
                else
                {
                    Console.WriteLine("Your demerit points is {0}", demeritPoints);
                }
            }
            catch
            {
                Console.WriteLine("Please enter in the correct format");
            }
        }
    }
}