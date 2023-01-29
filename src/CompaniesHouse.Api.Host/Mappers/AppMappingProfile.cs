using AutoMapper;
using CompaniesHouse.Api.Host.ApiClients.Contracts;
using CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyFilingHistories;
using CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyOfficeAddresses;
using CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyOfficers;
using CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles;
using CompaniesHouse.Api.Host.Apis.Dtos;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyFilingHistory;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyOfficeAddress;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyOfficer;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyProfile;
using CompaniesHouse.Api.Host.Data.Entities;
using CompanyStatusDetailEnum = CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles.CompanyStatusDetailEnum;
using CompanyStatusEnum = CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles.CompanyStatusEnum;

namespace CompaniesHouse.Api.Host.Mappers
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<Annotation, AnnotationDto>();
            CreateMap<AssociatedFiling, AssociatedFilingDto>();
            CreateMap<CompanyFilingHistory, CompanyFilingHistoryDto>();
            CreateMap<CompanyFilingHistoryItem, CompanyFilingHistoryItemDto>();
            CreateMap<CompanyFilingHistoryLinks, CompanyFilingHistoryLinksDto>();
            CreateMap<Resolution, ResolutionDto>();
            
            CreateMap<CompanyOfficeAddress, CompanyOfficeAddressDto>();
            CreateMap<CompanyOfficeLinks, CompanyOfficeLinksDto>();
            
            CreateMap<CompanyOfficerAddress, CompanyOfficerAddressDto>();
            CreateMap<CompanyOfficerDateOfBirth, CompanyOfficerDateOfBirthDto>();
            CreateMap<CompanyOfficers, CompanyOfficersDto>();
            CreateMap<CompanyOfficerIdentification, CompanyOfficerIdentificationDto>();
            CreateMap<CompanyOfficer, CompanyOfficerDto>();
            CreateMap<CompanyOfficerItemLinks, CompanyOfficerItemLinksDto>();
            CreateMap<CompanyOfficerLinks, CompanyOfficerLinksDto>();
            CreateMap<FormerName, FormerNameDto>();
            CreateMap<Officer, OfficerDto>();

            CreateMap<AccountingRequirement, AccountingRequirementDto>();
            CreateMap<BranchCompanyDetails, BranchCompanyDetailsDto>();
            CreateMap<CompanyProfileAccount, CompanyProfileAccountDto>();
            CreateMap<CompanyProfileAccounts, CompanyProfileAccountsDto>();
            CreateMap<CompanyProfileAnnualReturn, CompanyProfileAnnualReturnDto>();
            CreateMap<CompanyProfile, CompanyProfileDto>();
            CreateMap<CompanyProfileLastAccounts, CompanyProfileLastAccountsDto>();
            CreateMap<ForeignCompanyDetails, ForeignCompanyDetailsDto>();
            CreateMap<MustFileWithin, MustFileWithinDto>();
            CreateMap<OriginatingRegistry, OriginatingRegistryDto>();
            CreateMap<PreviousCompanyName, PreviousCompanyNameDto>();
            CreateMap<RegisteredOfficeAddress, RegisteredOfficeAddressDto>();

            CreateMap<Company, CompanyProfileDto>()
                .ForMember(m => m.DateOfCreation, options => options.MapFrom(dto => dto.IncorporationDate))
                .ForMember(m => m.CompanyStatus, options => options.MapFrom(dto => MapCompanyStatus(dto.CompanyStatus)))
                .ForMember(m => m.CompanyStatusDetail, options => options.MapFrom(dto => MapCompanyStatusDetails(dto.CompanyStatus)))
                .ForMember(m => m.Type, options => options.MapFrom(dto => dto.CompanyCategory))
                .ForPath(m => m.RegisteredOfficeAddress.AddressLine1, options => options.MapFrom(dto => dto.AddressLine1))
                .ForPath(m => m.RegisteredOfficeAddress.AddressLine2, options => options.MapFrom(dto => dto.AddressLine2))
                .ForPath(m => m.RegisteredOfficeAddress.Region, options => options.MapFrom(dto => dto.County))
                .ForPath(m => m.RegisteredOfficeAddress.PostalCode, options => options.MapFrom(dto => dto.PostCode))
                .ForPath(m => m.RegisteredOfficeAddress.Locality, options => options.MapFrom(dto => dto.PostTown))
                .ForMember(m => m.SicCodes, options => options.MapFrom(dto => GetSicTextList(dto)))
                .ForMember(m => m.PreviousCompanyNames, options => options.MapFrom(dto => GetPreviousCompanyNameDtoList(dto)));
        }
        
        private List<PreviousCompanyNameDto> GetPreviousCompanyNameDtoList(Company company)
        {
            var previousCompanyNameDtos = new List<PreviousCompanyNameDto>()
            {
                (GetPreviousCompanyNameDto(company.PreviousName1CompanyName)),
                (GetPreviousCompanyNameDto(company.PreviousName2CompanyName)),
                (GetPreviousCompanyNameDto(company.PreviousName3CompanyName)),
                (GetPreviousCompanyNameDto(company.PreviousName4CompanyName)),
                (GetPreviousCompanyNameDto(company.PreviousName5CompanyName)),
                (GetPreviousCompanyNameDto(company.PreviousName6CompanyName)),
                (GetPreviousCompanyNameDto(company.PreviousName7CompanyName)),
                (GetPreviousCompanyNameDto(company.PreviousName8CompanyName)),
                (GetPreviousCompanyNameDto(company.PreviousName9CompanyName)),
                (GetPreviousCompanyNameDto(company.PreviousName10CompanyName))
            };
            
            return ValidatePreviousCompanyNameDtos(previousCompanyNameDtos);
        }
        
        private PreviousCompanyNameDto GetPreviousCompanyNameDto(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }
            
            return new PreviousCompanyNameDto()
            {
                Name = name
            };
        }
        
        private List<PreviousCompanyNameDto> ValidatePreviousCompanyNameDtos(List<PreviousCompanyNameDto> previousCompanyNameDtos)
        {
            var test = new List<PreviousCompanyNameDto>();
            
            foreach (var previousCompanyNameDto in previousCompanyNameDtos)
            {
                if (previousCompanyNameDto == null)
                {
                    continue;
                }

                test.Add(previousCompanyNameDto);
            }

            return test;
        }
        
        private List<string> GetSicTextList(Company company)
        {
            var sicTexts = new List<string>()
            {
                company.SicText_1,
                company.SicText_2,
                company.SicText_3,
                company.SicText_4
            };
            
            var result = new List<string>();

            foreach (var sicText in sicTexts)
            {
                if (string.IsNullOrEmpty(sicText))
                {
                    continue;
                }
                else
                {
                    result.Add(sicText);
                }
            }

            return result;
        }

        private CompanyStatusEnum? MapCompanyStatus(string dbStatus)
        {
            switch (dbStatus.ToLower())
            {
                case "active":
                case "active - proposal to strike off":
                case "active proposal to strike off":
                    return CompanyStatusEnum.Active;
                case "dissolved":
                    return CompanyStatusEnum.Dissolved;
                case "liquidation":
                    return CompanyStatusEnum.Liquidation;
                case "in administration":
                case "administration order":
                    return CompanyStatusEnum.Administration;
                case "voluntary arrangement":
                    return CompanyStatusEnum.VoluntaryArrangement;
                case "receivership":
                case "receiver action":
                case "administrative receiver":
                case "live but receiver manager on at least one charge":
                    return CompanyStatusEnum.Receivership;
                case "insolvency proceedings":
                case "voluntary arrangement / administrative receiver":
                case "in administration/administrative receiver":
                case "receiver manager / administrative receiver":
                case "in administration/receiver manager":
                    return CompanyStatusEnum.InsolvencyProceedings;
                case "converted / closed":
                    return CompanyStatusEnum.ConvertedClosed;
                case "open":
                    return CompanyStatusEnum.Open;
                case "closed":
                    return CompanyStatusEnum.Closed;
                default:
                    return null;
            }
        }

        private CompanyStatusDetailEnum? MapCompanyStatusDetails(string dbStatus)
        {
            switch (dbStatus.ToLower())
            {
                case "active - proposal to strike off":
                case "active proposal to strike off":
                    return CompanyStatusDetailEnum.ActiveProposalToStrikeOff;
                case "transfer from uk":
                    return CompanyStatusDetailEnum.TransferFromUK;
                case "petition to restore dissolved":
                    return CompanyStatusDetailEnum.PetitionToRestoreDissolved;
                case "transformed to se":
                    return CompanyStatusDetailEnum.TransformedToSE;
                case "converted to plc":
                    return CompanyStatusDetailEnum.ConvertedToPLC;
                case "converted to uk societas":
                    return CompanyStatusDetailEnum.ConvertedToUKSocietas;
                case "converted to ukeig":
                    return CompanyStatusDetailEnum.ConvertedToUKEIG;
                default:
                    return null;
            }
        }
    }
}