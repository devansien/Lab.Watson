using IBM.Cloud.SDK.Core.Http;
using IBM.Cloud.SDK.Core.Util;
using IBM.Watson.Discovery.v1;
using IBM.Watson.Discovery.v1.Model;
using System;

namespace Watson
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenOptions tokenOptions = new TokenOptions
            {
                IamApiKey = "",
                ServiceUrl = "https://gateway.watsonplatform.net/discovery/api/"
            };

            DiscoveryService discoveryService = new DiscoveryService(tokenOptions, "2019-04-30");
            string envid = "";
            string colid = "";
            DetailedResponse<Collection> resp = discoveryService.GetCollection(envid, colid);

            Console.WriteLine(resp.Response);
            Console.ReadKey();
        }
    }
}
