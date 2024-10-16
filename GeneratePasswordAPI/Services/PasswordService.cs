using GeneratePasswordAPI.Models;
using GeneratePasswordAPI.Utils;

namespace GeneratePasswordAPI.Services
{
    public class PasswordService : IPasswordService
    {
        private const int MaxSymbols = 17;

        public string GeneratePassword(PasswordRequestModel request)
        {
            //Validation
            int totalChars = request.QtyNumbers + request.QtyUppercaseChars + request.QtySymbols;

            if (request.QtySymbols > MaxSymbols)
            {
                throw new ArgumentException($"QtySymbols cannot exceed {MaxSymbols}.");
            }

            if(request.Length < totalChars)
            {
                throw new ArgumentException($"The length of your password must be {totalChars} because of symbols,uppercase chars and numbers.");
            }

            //Generate
            return PasswordUtils.Generate(request.Length, request.QtySymbols, request.QtyNumbers, request.QtyUppercaseChars);
        }
    }
}
