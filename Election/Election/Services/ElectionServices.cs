using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plugin.RestClient;
using Election.SharedModel;

namespace Election.Services
{
    /* Service that send an asynchronous http request to the server to get the election data.
     * And based on the user input will refine the list usinf lambda expression.
     * The result is returned as a list
     */
    class ElectionServices
    {
        //asynchronous task to send http request
        public static async Task<List<SharedModel.Election>> GetElectionsAsync(string state, string county, string typename) {
            
            //define a RestClient that create the Http request
            RestClient<SharedModel.Election> restclient = new RestClient<SharedModel.Election>();

            //get the result of the Http request
            var electionlist = await restclient.GetAsync();

            //refine the result to get election result for the county specitied by the user
            var results = electionlist.Where(r => r.State.ToLower() == state && r.AreaName.ToLower() == county && r.TypeOfElection.ToLower() == typename);

            return results.ToList();
        }
    }
}
