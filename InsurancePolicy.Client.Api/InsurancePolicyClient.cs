namespace InsurancePolicy.Client.Api
{
    using Application.ViewModels;
    using Newtonsoft.Json;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;
    using System.Reflection;

    public class InsurancePolicyClient<T>
    {
        public string Endpoint { get; set; }

        public InsurancePolicyClient(string endpoint)
        {
            this.Endpoint = endpoint;
        }

        public IEnumerable<T> ExecuteGet()
        {
            RestClient restClient = new RestClient(Endpoint);
            RestRequest restRequest = new RestRequest(Method.GET);
            IRestResponse response = restClient.Execute(restRequest);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }

            return (IEnumerable<T>)JsonConvert.DeserializeObject(response.Content, typeof(IEnumerable<T>));
        }
        public void ExecutePost(object request)
        {
            RestClient restClient = new RestClient(Endpoint);
            RestRequest restRequest = new RestRequest(Method.POST);

            string json = JsonConvert.SerializeObject(request);
            restRequest.AddParameter("application/json", json, ParameterType.RequestBody);

            IRestResponse response = restClient.Execute(restRequest);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }
        }
        public void ExecutePut(object request)
        {
            RestClient restClient = new RestClient(Endpoint);
            RestRequest restRequest = new RestRequest(Method.PUT);

            string json = JsonConvert.SerializeObject(request);
            restRequest.AddParameter("application/json", json, ParameterType.RequestBody);

            IRestResponse response = restClient.Execute(restRequest);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }
        }
        public void ExecuteDelete(object request)
        {
            RestClient restClient = new RestClient(Endpoint);
            RestRequest restRequest = new RestRequest(Method.DELETE);
            restRequest.AddJsonBody(request);
            IRestResponse response = restClient.Execute(restRequest);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }
        }
    }
    public class RootGetInsurancePolicyResponse
    {
        public IEnumerable<InsurancePolicyViewModel> InsurancePolicyViewModel { get; set; }
    }
}
