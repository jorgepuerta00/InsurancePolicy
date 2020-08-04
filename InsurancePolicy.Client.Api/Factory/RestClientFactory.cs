namespace InsurancePolicy.Client.Api.Factory
{
    using Interfaces;
    using RestSharp;
    public class RestClientFactory : IRestClientFactory
    {
        public RestClient Create(string baseUrl)
        {
            return new RestClient(baseUrl);
        }
    }
}
