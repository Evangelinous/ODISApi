using System.Threading.Tasks;
using ODISApi.Models;

namespace ODISApi.Services
{
    public interface IAddressService
    {
        Task<AddressDto> GetAddressAsync(string addressId);
        Task<AddressDto> CreateOrUpdateAddressAsync(AddressDto address);
    }
}
