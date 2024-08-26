using System.Threading.Tasks;
using ODISApi.Models;

namespace ODISApi.Services
{
    public class AddressService : IAddressService
    {
        public async Task<AddressDto> GetAddressAsync(string addressId)
        {
            // Mocked Address Data with all fields populated
            return await Task.FromResult(new AddressDto
            {
                AddressId = new DmsIdentifier { InternalId = addressId, ExternalId = "EXT123" },
                BusinessPartnerId = new DmsIdentifier { InternalId = "BP123", ExternalId = "EXTBP123" },
                ContactPersonId = new DmsIdentifier { InternalId = "CP123", ExternalId = "EXTCP123" },
                Street = "123 Main St",
                Block = "Block A",
                ZipCode = "12345",
                City = "Sample City",
                County = "Sample County",
                State = "Sample State",
                StreetNo = "10A",
                Longitude = "12.345678",
                Latitude = "-98.765432",
                FederalTaxId = "FT123456",
                TaxCode = "TAX123",
                BuildingFloorRoom = "Floor 3, Room 12",
                CountryId = new DmsIdentifier { InternalId = "C123", ExternalId = "EXTC123" },
                PlaceType = PlaceTypeEnum.Home,
                AddressType = AddressTypeEnum.BillTo,
                IsDefault = true,
                AltLanguageStreet = "123 Rue Principale",
                AltLanguageCity = "Ville Échantillon",
                AltLanguageStateDescription = "État Échantillon",
                AltLanguageBlock = "Bloc A",
                AltLanguageBuildingFloorRoom = "Étage 3, Chambre 12"
            });
        }

        public async Task<AddressDto> CreateOrUpdateAddressAsync(AddressDto address)
        {
            // Here you would typically save the address to a database
            return await Task.FromResult(address); // Mocked Response
        }
    }
}
