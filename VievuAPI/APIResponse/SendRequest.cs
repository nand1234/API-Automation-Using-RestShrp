using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using VievuAPI.APIClient;
namespace VievuAPI.APIResponse
{
    class SendRequest
    {
        private static IRestResponse response;
      
        /// <summary>
        /// Send Request to Server and return response
        /// </summary>
        /// <param name="request"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        public static IRestResponse sendRequest(RestRequest request, RestClient client)
        {
            response = client.Execute(request);
            return response;

        }
    }
}
