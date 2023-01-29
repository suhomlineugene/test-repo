namespace CompaniesHouse.Api.Host.Exceptions
{
    public class CompaniesHouseApiServerException : Exception
    {
        public CompaniesHouseApiServerException(string message)
            : base(message) {}
    }
}
