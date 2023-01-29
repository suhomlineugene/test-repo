namespace CompaniesHouse.Api.Host.Apis.Dtos.CompanyOfficer
{
    public class CompanyOfficerDto
    {
        public CompanyOfficerAddressDto CompanyOfficerAddress { get; set; }
        
        public string AppointedOn { get; set; }
        
        public string CountryOfResidence { get; set; }
        
        public CompanyOfficerDateOfBirthDto CompanyOfficerDateOfBirth { get; set; }
        
        public List<FormerNameDto> FormerNames { get; set; }
        
        public CompanyOfficerIdentificationDto CompanyOfficerIdentification { get; set; }
        
        public CompanyOfficerItemLinksDto Links { get; set; }
        
        public string Name { get; set; }
        
        public string Nationality { get; set; }
        
        public string Occupation { get; set; }
        
        public string OfficerRole { get; set; }
        
        public DateTime? ResignedOn { get; set; }
    }
}