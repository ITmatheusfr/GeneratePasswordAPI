using GeneratePasswordAPI.Models;

namespace GeneratePasswordAPI.Services
{
    public interface IPasswordService
    {
        string GeneratePassword(PasswordRequestModel request);
    }
}
