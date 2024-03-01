namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //vowels: A, a, E, e, I, i, O, o, U, u

            Console.WriteLine(GetVowelsCount(text));

            static int GetVowelsCount (string text)
            {
                int count = 0;
                for (int position = 0; position <= text.Length -1;  position++)
                {
                    char symbol = text[position];
                    if (symbol == 'A' || symbol == 'a' || symbol == 'E' || symbol == 'e' || symbol == 'I' || symbol == 'i' || symbol == 'O' || symbol == 'o' || symbol == 'U' || symbol == 'u')
                    {
                        count++;
                    } 
                }
                return count;
            }
        }
    }
}