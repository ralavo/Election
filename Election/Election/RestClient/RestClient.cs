using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Plugin.RestClient
{
    // RestClient implements methods for calling CRUD operations using HTTP.
    public class RestClient<T>
    {
        //define webAPI address
        private const string WebServiceUrl = "http://localhost:3000/api/Elections/";

        public async Task<List<T>> GetAsync()
        {
            //create httpclient object
            var httpClient = new HttpClient();

            //Http request that return a json object
            var json = await httpClient.GetStringAsync(WebServiceUrl);

            //deserialization of the json object into a list object
            //done by the Newtonsoft.Json paquage
            var taskModels = JsonConvert.DeserializeObject<List<T>>(json);

            return taskModels;
        }
    }  
}
