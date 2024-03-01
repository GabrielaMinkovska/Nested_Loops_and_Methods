namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            //validation: contain 6 – 10 characters (inclusive); only letters and digits; at least 2 digits 

            bool isValidLength = password.Length >= 6 && password.Length <= 10;
            bool isValidContent = CheckContent(password);
            bool isValidCountDigits = CheckDigitCount(password);


            if (isValidLength == true && isValidContent == true && isValidCountDigits == true)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (isValidLength == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (isValidContent == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (isValidCountDigits == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
            
            static bool CheckContent (string password)
            {
                for (int position = 0; position <= password.Length - 1; position++)
                {
                    char symbol = password[position];
                    if (char.IsLetterOrDigit(symbol) == false)
                    {
                        return false;
                    }
                }
                return true;
            }

            static bool CheckDigitCount (string password)
            {
                int count = 0;
                for (int position = 0; position <= password.Length - 1; position++)
                {
                    char symbol = password[position];
                    if (char.IsDigit(symbol) == true)
                    {
                        count++;
                    }
                }
                return count >= 2;
            }
        }
    }
}