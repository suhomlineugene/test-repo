using System.Runtime.Serialization;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles
{
    public enum CompanyStatusEnum
    {
        [EnumMember(Value = "active")]
        Active = 1,

        [EnumMember(Value = "dissolved")]
        Dissolved = 2,

        [EnumMember(Value = "liquidation")]
        Liquidation = 3,

        [EnumMember(Value = "receivership")]
        Receivership = 4,

        [EnumMember(Value = "administration")]
        Administration = 5,

        [EnumMember(Value = "voluntary-arrangement")]
        VoluntaryArrangement = 6,

        [EnumMember(Value = "converted-closed")]
        ConvertedClosed = 7,

        [EnumMember(Value = "insolvency-proceedings")]
        InsolvencyProceedings = 8,

        [EnumMember(Value = "open")]
        Open = 9,

        [EnumMember(Value = "closed")]
        Closed = 10,
    }
}