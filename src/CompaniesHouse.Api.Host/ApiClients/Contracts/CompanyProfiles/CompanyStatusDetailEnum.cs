using System.Runtime.Serialization;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles
{
    public enum CompanyStatusDetailEnum
    {
        [EnumMember(Value = "transferred-from-uk")]
        TransferFromUK = 1,

        [EnumMember(Value = "active-proposal-to-strike-off")]
        ActiveProposalToStrikeOff = 2,

        [EnumMember(Value = "petition-to-restore-dissolved")]
        PetitionToRestoreDissolved = 3,

        [EnumMember(Value = "transformed-to-se")]
        TransformedToSE = 4,

        [EnumMember(Value = "converted-to-plc")]
        ConvertedToPLC = 5,

        [EnumMember(Value = "onverted-to-uk-societas")]
        ConvertedToUKSocietas = 6,

        [EnumMember(Value = "converted-to-ukeig")]
        ConvertedToUKEIG = 7,
    }
}