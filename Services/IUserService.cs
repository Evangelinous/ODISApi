using ODISApi.Models;

namespace ODISApi.Services
{
    public interface IUserService
    {
        UserDataModel ValidateUser(string username, string password);
    }
}
