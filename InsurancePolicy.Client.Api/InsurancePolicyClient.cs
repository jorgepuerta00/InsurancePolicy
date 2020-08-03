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

    public class InsurancePolicyClient
    {
        public string Endpoint { get; set; }

        public InsurancePolicyClient(string endpoint)
        {
            this.Endpoint = endpoint;
        }

        public T ExecuteGet<T>()
        {
            RestClient restClient = new RestClient(Endpoint);
            RestRequest restRequest = new RestRequest(Method.GET);
            IRestResponse response = restClient.Execute(restRequest);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }

            return (T)JsonConvert.DeserializeObject(response.Content, typeof(T));
        }
        public T ExecutePost<T>(Object request)
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

            return (T)JsonConvert.DeserializeObject(response.Content, typeof(T));
        }
        public T ExecutePut<T>(Object request)
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

            return (T)JsonConvert.DeserializeObject(response.Content, typeof(T));
        }
        public T ExecuteDelete<T>(Object request)
        {
            RestClient restClient = new RestClient(Endpoint);
            RestRequest restRequest = new RestRequest(Method.DELETE);
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
        public IEnumerable<InsurancePolicyViewModel> InsurancePolicyViewModel { get; set; }
    }
}
