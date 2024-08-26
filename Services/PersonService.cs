using System.Threading.Tasks;
using ODISApi.Models;

namespace ODISApi.Services
{
    public class PersonService : IPersonService
    {
        public async Task<PersonDto> GetPersonAsync(string personId)
        {
            // Mocked Person Data with all fields populated
            return await Task.FromResult(new PersonDto
            {
                Id = new DmsIdentifier { InternalId = personId, ExternalId = "EXT-PERSON-123" },
                BusinessPartner = new DmsIdentifier { InternalId = "BP123", ExternalId = "EXT-BP-123" },
                FirstName = "John",
                MiddleName = "A.",
                Surname = "Doe",
                Title = new DmsIdentifier { InternalId = "TITLE123", ExternalId = "EXT-TITLE-123" },
                CommunicationInfo = new CommunicationInfoDto
                {
                    Addresses = new List<AddressDto>
            {
                new AddressDto
                {
                    AddressId = new DmsIdentifier { InternalId = "ADDR123", ExternalId = "EXT-ADDR-123" },
                    BusinessPartnerId = new DmsIdentifier { InternalId = "BPADDR123", ExternalId = "EXT-BPADDR-123" },
                    ContactPersonId = new DmsIdentifier { InternalId = "CONTACT123", ExternalId = "EXT-CONTACT-123" },
                    Street = "123 Main St",
                    Block = "Block A",
                    ZipCode = "12345",
                    City = "Sample City",
                    County = "Sample County",
                    State = "Sample State",
                    StreetNo = "12A",
                    Longitude = "50.123456",
                    Latitude = "-100.654321",
                    FederalTaxId = "FEDTAX123",
                    TaxCode = "TAXCODE123",
                    BuildingFloorRoom = "Floor 1, Room 101",
                    CountryId = new DmsIdentifier { InternalId = "COUNTRY123", ExternalId = "EXT-COUNTRY-123" },
                    PlaceType = PlaceTypeEnum.Home,
                    AddressType = AddressTypeEnum.BillTo,
                    IsDefault = true,
                    AltLanguageStreet = "Alt St",
                    AltLanguageCity = "Alt City",
                    AltLanguageStateDescription = "Alt State",
                    AltLanguageBlock = "Alt Block",
                    AltLanguageBuildingFloorRoom = "Alt Floor 1, Alt Room 101"
                }
            },
                    Email = "john.doe@example.com",
                    MobileNum = "+1234567890",
                    Fax = "+111222333",
                    PhoneNum = "+0987654321",
                    PhoneNum1 = "+111333444",
                    PhoneNum2 = "+222444555",
                    HomeFax = "+333555666",
                    Home = "123 Home St",
                    HomeMobile = "+444666777",
                    HomeEmail = "home.john.doe@example.com",
                    HomeWebsite = "http://home.example.com",
                    Work = "456 Work St",
                    WorkFax = "+555777888",
                    WorkMobile = "+666888999",
                    WorkEmail = "work.john.doe@example.com",
                    WorkWebsite = "http://work.example.com",
                    WorkCompanyName = "John Doe Inc.",
                    WorkPhoneAssistant = "+777999000",
                    WorkPhoneReception = "+888000111",
                    FacebookUrl = "http://facebook.com/johndoe",
                    LinkedinUrl = "http://linkedin.com/in/johndoe",
                    TwitterUrl = "http://twitter.com/johndoe",
                    SocialNo = "SN123456789"
                },
                PaymentInfo = new PaymentInfoDto
                {
                    PreferredCurrency = new DmsIdentifier { InternalId = "CUR123", ExternalId = "EXT-CUR-123" },
                    FederalTaxId = "FEDTAX123",
                    UnifiedFederalTaxId = "UFTAX123",
                    CompanyRegistrationNumber = "CRN123",
                    TaxOffice = "Sample Tax Office",
                    VatGroup = new DmsIdentifier { InternalId = "VAT123", ExternalId = "EXT-VAT-123" },
                    PaymentTermsCode = new DmsIdentifier { InternalId = "PTC123", ExternalId = "EXT-PTC-123" },
                    PaymentTypeCode = new DmsIdentifier { InternalId = "PTC456", ExternalId = "EXT-PTC-456" },
                    CustomerTaxNumberList = new List<CustomerTaxNumber>
            {
                new CustomerTaxNumber
                {
                    TaxNumberId = new DmsIdentifier { InternalId = "TAXID123", ExternalId = "EXT-TAXID-123" },
                    Value = "123-45-6789"
                }
            }
                },
                AgeRange = "30-40",
                CityOfBirth = "Sample City",
                Gender = new DmsIdentifier { InternalId = "GENDER123", ExternalId = "EXT-GENDER-123" },
                LanguageCode = new DmsIdentifier { InternalId = "LANG123", ExternalId = "EXT-LANG-123" },
                MaritalStatus = new DmsIdentifier { InternalId = "MARITAL123", ExternalId = "EXT-MARITAL-123" },
                NoOfChildren = 2,
                Pets = 1,
                Position = "Software Engineer",
                Profession = new DmsIdentifier { InternalId = "PROF123", ExternalId = "EXT-PROF-123" },
                Salutation = "Mr.",
                LetterSalutation = "Dear Mr. Doe",
                SocialNo = "SN123456789",
                VocativeFirstName = "John",
                VocativeLastName = "Doe",
                WeddingAnniversary = DateTime.Parse("2000-05-20"),
                BirthDate = DateTime.Parse("1985-04-15"),
                IsDefault = true,
                SalesPersonCode = new DmsIdentifier { InternalId = "SP123", ExternalId = "EXT-SP-123" },
                EmptyEmailReason = EmptyEmailReasonTypeEnum.NotProvided
            });
        }


        public async Task<PersonDto> CreateOrUpdatePersonAsync(PersonDto person)
        {
            // Here you would typically save the person to a database
            return await Task.FromResult(person); // Mocked Response
        }
    }
}
