namespace ODISApi.Models
{
    public class AddressDto
    {
        public DmsIdentifier AddressId { get; set; }
        public DmsIdentifier BusinessPartnerId { get; set; }
        public DmsIdentifier ContactPersonId { get; set; }
        public string Street { get; set; }
        public string Block { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string StreetNo { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string FederalTaxId { get; set; }
        public string TaxCode { get; set; }
        public string BuildingFloorRoom { get; set; }
        public DmsIdentifier CountryId { get; set; }
        public PlaceTypeEnum PlaceType { get; set; }
        public AddressTypeEnum AddressType { get; set; }
        public bool? IsDefault { get; set; }
        public string AltLanguageStreet { get; set; }
        public string AltLanguageCity { get; set; }
        public string AltLanguageStateDescription { get; set; }
        public string AltLanguageBlock { get; set; }
        public string AltLanguageBuildingFloorRoom { get; set; }
    }

    public enum PlaceTypeEnum
    {
        Home,
        Work,
        Unknown
    }

    public enum AddressTypeEnum
    {
        BillTo,
        ShipTo
    }

    public class DmsIdentifier
    {
        public string InternalId { get; set; }
        public string ExternalId { get; set; }
    }
}
