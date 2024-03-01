namespace Magic_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //{digit 1}{digit 2}{digit 3} in range [100; 999]
            //digit 1 is in range [1; 9], digit 2 is in range [0; 9], digit 3 is in range [0; 9]

            for (int digit1 = 1; digit1 <= 9; digit1++)
            {
                for (int digit2 = 0; digit2 <= 9; digit2++)
                {
                    for (int digit3 = 0; digit3 <= 9; digit3++)
                    {
                        // {digit1}{digit2}{digit3}
                        // check if d1 * d2 * d3 = n
                        if (digit1 * digit2 * digit3 == n)
                        {
                            Console.Write($"{digit1}{digit2}{digit3} ");
                        }
                    }
                }
            }
        }
    }
}