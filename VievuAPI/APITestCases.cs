using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VievuAPI.APIClient;
using VievuAPI.APIRequest;
using VievuAPI.APIResponse;
using Newtonsoft.Json;
using RestSharp;
using VievuAPI.PostData;

namespace VievuAPI
{
    [TestClass]
    public class APITestCases
    {
        private RestClient client;
        private RestRequest request;
        private IRestResponse Response;

        [TestMethod]
        public void APIGet()
        {

            client = Client.GetClient("http://vievuautomationapi.cloudapp.net/api/TestData");
            request = Request.SetRequestVerb("GET");
            // request = Request.SetResource(Method.GET, "/394BA378-6299-4DD7-92EB-5454E8FD021A");
            request = Request.AddRequestHeaders("Content-Type", "application/json");
            Response = SendRequest.sendRequest(request, client);
            var StatusCode = Response.StatusCode;
            Console.WriteLine(StatusCode);
        }
        [TestMethod]
        public void APIPost()
        {
            JsonRequestBody Jbody = new JsonRequestBody();
            String requestbody = Jbody.GetJsonbody();
            client = Client.GetClient("http://vievuautomationapi.cloudapp.net/Api/TestResults");
            request = Request.SetRequestVerb("POST");
            request = Request.AddRequestHeaders("Content-Type", "application/json");
            request = Request.AddRequestBody(requestbody);
            Response = SendRequest.sendRequest(request, client);
            var jsonResponse = JsonConvert.DeserializeObject(Response.Content);
            Console.WriteLine(jsonResponse);
        }
    }
}
