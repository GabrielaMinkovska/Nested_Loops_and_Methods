namespace Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max1 = int.Parse(Console.ReadLine());
            int max2 = int.Parse(Console.ReadLine());
            int max3 = int.Parse(Console.ReadLine());

            //PIN: {digit1}{digit2}{digit3}
            //digit1 range: [1; max1]; digit2 range: [1; max2]; digit3 range: [1; max3]
            //digit 1 and digit 3 must be even, digit2 must be prime number [2; 7] - 2,3,5,7

            for (int digit1 = 2; digit1 <= max1; digit1 += 2)
            {
                for (int digit2 = 1; digit2 <= max2; digit2++)
                {
                    for (int digit3 = 2; digit3 <= max3; digit3 +=2)
                    {
                        //PIN: {digit1}{digit2}{digit3} and digit2 must be prime number [2; 7] - 2,3,5,7
                        if (digit2 ==2 || digit2 == 3 || digit2 == 5 || digit2 == 7)
                        {
                            Console.WriteLine($"{digit1}{digit2}{digit3}");
                        }
                    }
                }
            }

        }
    }
}