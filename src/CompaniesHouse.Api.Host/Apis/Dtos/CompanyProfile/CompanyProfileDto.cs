namespace CompaniesHouse.Api.Host.Apis.Dtos.CompanyProfile
{
    public class CompanyProfileDto
    {
        public CompanyProfileAccountsDto Accounts { get; set; }
        
        public CompanyProfileAnnualReturnDto CompanyProfileAnnualReturnDto { get; set; }
        
        public BranchCompanyDetailsDto BranchCompanyDetailsDto { get; set; }
        
        public bool CanFile { get; set; }

        public string CompanyName { get; set; }

        public string CompanyNumber { get; set; }

        public CompanyStatusEnum? CompanyStatus { get; set; }
        
        public CompanyStatusDetailEnum? CompanyStatusDetail { get; set; }
        
        public CompanyProfileAnnualReturnDto ConfirmationStatement { get; set; }
        
        public DateTime? DateOfCessation { get; set; }
        
        public DateTime? DateOfCreation { get; set; }
        
        public string Etag { get; set; }
        
        public ForeignCompanyDetailsDto ForeignCompanyDetailsDto { get; set; }
        
        public bool HasBeenLiquidated { get; set; }
        
        public bool HasCharges { get; set; }
        
        public bool HasInsolvencyHistory { get; set; }
        
        public bool IsCommunityInterestCompany { get; set; }
        
        public string Jurisdiction { get; set; }
        
        public DateTime? LastFullMembersListDate { get; set; }
        
        public CompanyProfileLinksDto CompanyProfileLinksDto { get; set; }
        
        public List<PreviousCompanyNameDto> PreviousCompanyNames { get; set; }
        
        public RegisteredOfficeAddressDto RegisteredOfficeAddress { get; set; }
        
        public bool RegisteredOfficeIsInDispute { get; set; }
        
        public List<string> SicCodes { get; set; }
        
        public string Type { get; set; }
        
        public bool UndeliverableRegisteredOfficeAddress { get; set; }
    }
}