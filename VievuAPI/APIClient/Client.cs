using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VievuAPI.APIClient
{
    class Client
    {

        private static RestClient client;

        /// <summary>
        /// It accept Client URI and return Client instance
        /// </summary>
        /// <param name="Accept URL detail as parameter"></param>
        /// <returns></returns>
        public static RestClient GetClient(String URI)
        {
            client = new RestClient(URI);
            return client;


        }


    }
}
