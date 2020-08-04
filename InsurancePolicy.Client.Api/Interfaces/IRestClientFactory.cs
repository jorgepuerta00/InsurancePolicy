namespace InsurancePolicy.Client.Api.Interfaces
{
    using RestSharp;
    public interface IRestClientFactory
    {
        RestClient Create(string baseUrl);
    }
}
