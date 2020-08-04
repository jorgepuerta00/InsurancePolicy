namespace InsurancePolicy.Client.Api.Interfaces
{
    using RestSharp;
    public interface IRestRequestFactory
    {
        RestRequest Create(string url, Method method);
    }
}
