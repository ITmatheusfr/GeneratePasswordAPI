using System.Text;
using System.Security.Cryptography;

namespace GeneratePasswordAPI.Utils
{
    public static class PasswordUtils
    {

        public static string Generate(int lengthPassword, int numSymbols, int numNumbers, int numUppercase)
        {
            // Collections of chars
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string symbols = "!@#$%^&*()_-+=<>?";

            Random random = new Random();
            StringBuilder finalPassword = new StringBuilder(lengthPassword);

            // Temp list for store characters choosed
            List<char> passwordChars = new List<char>();

            // Add the qty requested of uppercase chars
            for (int i = 0; i < numUppercase; i++)
            {
                passwordChars.Add(uppercase[random.Next(uppercase.Length)]);
            }

            // Add the qty requested of numbers
            for (int i = 0; i < numNumbers; i++)
            {
                passwordChars.Add(numbers[random.Next(numbers.Length)]);
            }

            // Add the qty requested of symbols
            for (int i = 0; i < numSymbols; i++)
            {
                passwordChars.Add(symbols[random.Next(symbols.Length)]);
            }

            // Fill with lowercase chars
            while (passwordChars.Count < lengthPassword)
            {
                passwordChars.Add(lowercase[random.Next(lowercase.Length)]);
            }

            // Shuffle the characters
            passwordChars = passwordChars.OrderBy(c => random.Next()).ToList();

            // Build the final password
            foreach (char c in passwordChars)
            {
                finalPassword.Append(c);
            }

            return finalPassword.ToString();
        }

    }
}
