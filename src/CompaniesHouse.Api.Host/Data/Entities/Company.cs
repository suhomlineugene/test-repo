using System.ComponentModel.DataAnnotations.Schema;

namespace CompaniesHouse.Api.Host.Data.Entities
{
    [Table("Companies")]
    public class Company
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string CompanyNumber { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string PostTown { get; set; }

        public string County { get; set; }

        public string PostCode { get; set; }

        public string CompanyCategory { get; set; }

        public string CompanyStatus { get; set; }

        public DateTime? DissolutionDate { get; set; }

        public DateTime? IncorporationDate { get; set; }

        public int? AccountRefDay { get; set; }

        public int? AccountRefMonth { get; set; }

        public DateTime? NextDueDate { get; set; }

        public DateTime? LastMadeUpDate { get; set; }

        public string AccountCategory { get; set; }

        public DateTime? ReturnNextDueDate { get; set; }

        public DateTime? ReturLastMadeUpDate { get; set; }

        public string NumMortCharges { get; set; }

        public string NumMortOutstanding { get; set; }

        public string NumMortPartSatisfied { get; set; }

        public string NumMortSatisfied { get; set; }

        public string SicText_1 { get; set; }

        public string SicText_2 { get; set; }

        public string SicText_3 { get; set; }

        public string SicText_4 { get; set; }

        public int? NumGenPartners { get; set; }

        public int? NumLimPartners { get; set; }

        public string URI { get; set; }

        public string PreviousName1CONDATE { get; set; }

        public string PreviousName1CompanyName { get; set; }

        public string PreviousName2CONDATE { get; set; }

        public string PreviousName2CompanyName { get; set; }

        public string PreviousName3CONDATE { get; set; }

        public string PreviousName3CompanyName { get; set; }

        public string PreviousName4CONDATE { get; set; }

        public string PreviousName4CompanyName { get; set; }

        public string PreviousName5CONDATE { get; set; }

        public string PreviousName5CompanyName { get; set; }

        public string PreviousName6CONDATE { get; set; }

        public string PreviousName6CompanyName { get; set; }

        public string PreviousName7CONDATE { get; set; }

        public string PreviousName7CompanyName { get; set; }

        public string PreviousName8CONDATE { get; set; }

        public string PreviousName8CompanyName { get; set; }

        public string PreviousName9CONDATE { get; set; }

        public string PreviousName9CompanyName { get; set; }

        public string PreviousName10CONDATE { get; set; }

        public string PreviousName10CompanyName { get; set; }

        public DateTime? ConfStmtNextDueDate { get; set; }

        public DateTime? ConfStmtLastMadeUpDate { get; set; }
    }
}
