using System.Collections.Generic;
using ODISApi.Models;

namespace ODISApi.Services
{
    public interface ISessionService
    {
        string GenerateJwtToken(string username, IList<string> roles);
    }
}
