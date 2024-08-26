using System.Threading.Tasks;
using ODISApi.Models;

namespace ODISApi.Services
{
    public interface IPersonService
    {
        Task<PersonDto> GetPersonAsync(string personId);
        Task<PersonDto> CreateOrUpdatePersonAsync(PersonDto person);
    }
}
