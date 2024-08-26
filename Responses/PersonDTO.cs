namespace ODISApi.Models
{
    public class PersonDto
    {
        public DmsIdentifier Id { get; set; }
        public DmsIdentifier BusinessPartner { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public DmsIdentifier Title { get; set; }
        public CommunicationInfoDto CommunicationInfo { get; set; }
        public PaymentInfoDto PaymentInfo { get; set; }
        public string AgeRange { get; set; }
        public string CityOfBirth { get; set; }
        public DmsIdentifier Gender { get; set; }
        public DmsIdentifier LanguageCode { get; set; }
        public DmsIdentifier MaritalStatus { get; set; }
        public int? NoOfChildren { get; set; }
        public int? Pets { get; set; }
        public string Position { get; set; }
        public DmsIdentifier Profession { get; set; }
        public string Salutation { get; set; }
        public string LetterSalutation { get; set; }
        public string SocialNo { get; set; }
        public string VocativeFirstName { get; set; }
        public string VocativeLastName { get; set; }
        public DateTime? WeddingAnniversary { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool? IsDefault { get; set; }
        public DmsIdentifier SalesPersonCode { get; set; }
        public EmptyEmailReasonTypeEnum EmptyEmailReason { get; set; }
    }

    public enum EmptyEmailReasonTypeEnum
    {
        Unset,
        NotAvailable,
        NotProvided
    }

    public class CommunicationInfoDto
    {
        public List<AddressDto> Addresses { get; set; }
        public string Email { get; set; }
        public string MobileNum { get; set; }
        public string Fax { get; set; }
        public string PhoneNum { get; set; }
        public string PhoneNum1 { get; set; }
        public string PhoneNum2 { get; set; }
        public string HomeFax { get; set; }
        public string Home { get; set; }
        public string HomeMobile { get; set; }
        public string HomeEmail { get; set; }
        public string HomeWebsite { get; set; }
        public string Work { get; set; }
        public string WorkFax { get; set; }
        public string WorkMobile { get; set; }
        public string WorkEmail { get; set; }
        public string WorkWebsite { get; set; }
        public string WorkCompanyName { get; set; }
        public string WorkPhoneAssistant { get; set; }
        public string WorkPhoneReception { get; set; }
        public string FacebookUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string SocialNo { get; set; }
    }

    public class PaymentInfoDto
    {
        public DmsIdentifier PreferredCurrency { get; set; }
        public string FederalTaxId { get; set; }
        public string UnifiedFederalTaxId { get; set; }
        public string CompanyRegistrationNumber { get; set; }
        public string TaxOffice { get; set; }
        public DmsIdentifier VatGroup { get; set; }
        public DmsIdentifier PaymentTermsCode { get; set; }
        public DmsIdentifier PaymentTypeCode { get; set; }
        public List<CustomerTaxNumber> CustomerTaxNumberList { get; set; }
    }

    public class CustomerTaxNumber
    {
        public DmsIdentifier TaxNumberId { get; set; }
        public string Value { get; set; }
    }
}
