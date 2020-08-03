namespace InsurancePolicy.Client.Api
{
    using InsurancePolicy.Application.ViewModels;
    using Newtonsoft.Json;
    using RestSharp;
    using System;
    using System.Collections.Generic;

    public class InsurancePolicyClient
    {
        public T ExecuteGet<T>(string endpoint)
        {
            RestClient restClient = new RestClient(endpoint);
            RestRequest restRequest = new RestRequest(Method.GET);
            IRestResponse response = restClient.Execute(restRequest);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }

            return (T)JsonConvert.DeserializeObject(response.Content, typeof(T));
        }
        public T ExecutePost<T>(Object request, string endpoint)
        {
            RestClient restClient = new RestClient(endpoint);
            RestRequest restRequest = new RestRequest(Method.POST);
            restRequest.AddJsonBody(request);
            IRestResponse response = restClient.Execute(restRequest);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }

            return (T)JsonConvert.DeserializeObject(response.Content, typeof(T));
        }
    }
    public class RootGetInsurancePolicyResponse
    {
        public List<InsurancePolicyViewModel> InsurancePolicyViewModel { get; set; }
    }
}
