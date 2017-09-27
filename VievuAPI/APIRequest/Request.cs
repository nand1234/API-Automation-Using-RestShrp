using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace VievuAPI.APIRequest
{
    class Request
    {
        private static RestRequest request;

        /// <summary>
        /// Return Request for provided HttpVerb
        /// </summary>
        /// <param name="HttpVerb"></param>
        /// <returns></returns>
        public static RestRequest SetRequestVerb(String HttpVerb)
        {
            switch (HttpVerb)
            {
                case "GET":

                    request = new RestRequest(Method.GET);
                    break;
                case "POST":

                    request = new RestRequest(Method.POST);
                    break;
                case "PUT":

                    request = new RestRequest(Method.PUT);
                    break;
                case "PATCH":

                    request = new RestRequest(Method.PATCH);
                    break;
                case "DELETE":

                    request = new RestRequest(Method.DELETE);
                    break;
            }
            return request;
        }

        /// <summary>
        /// Return Resource info for the URI
        /// </summary>
        /// <param name="Verb"></param>
        /// <param name="ResourceName"></param>
        /// <returns></returns>
        public static RestRequest SetResource(Method Verb, String ResourceName)
        {
            request = new RestRequest(ResourceName, Verb);
            return request;

        }
        /// <summary>
        /// Add header values to request
        /// </summary>
        /// <param name="HeaderName"></param>
        /// <param name="HeaderValue"></param>
        /// <returns></returns>
        public static RestRequest AddRequestHeaders(String HeaderName, String HeaderValue)
        {
            request.AddHeader(HeaderName, HeaderValue);
            return request;
        }

        /// <summary>
        /// Add Jsonbody to request Body
        /// </summary>
        /// <param name="JsonBody"></param>
        /// <returns></returns>
        public static RestRequest AddRequestBody(String JsonBody)

        {
            request.AddParameter("application/json",JsonBody,ParameterType.RequestBody);
            return request;
        }
        /// <summary>
        /// Add AddQueryParameter and value to URL
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static RestRequest AddQueryParameter(String QueryParam, String Queryvalue)

        {
            request.AddQueryParameter(QueryParam, Queryvalue);
            return request;
        }

        /// <summary>
        /// Add AddURIParameter and value to URL
        /// </summary>
        /// <param name="URlParam"></param>
        /// <param name="URIvalue"></param>
        /// <returns></returns>
        public static RestRequest AddUrlSegment(String URlParam, String URIvalue)

        {
            request.AddUrlSegment(URlParam, URIvalue);
            return request;
        }
    }
}
