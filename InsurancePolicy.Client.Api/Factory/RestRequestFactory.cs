namespace InsurancePolicy.Client.Api.Factory
{
    using Interfaces;
    using RestSharp;
    class RestRequestFactory : IRestRequestFactory
    {
        public RestRequest Create(string url, Method method)
        {
            return new RestRequest(url, method);
        }
    }
}
