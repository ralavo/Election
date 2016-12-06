using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.RestClient;
using Election.SharedModel;

namespace Election.Services
{
    class ElectionServices
    {
        public static async Task<List<SharedModel.Election>> GetElectionsAsync(string state, string county, string typename) {

            RestClient<SharedModel.Election> restclient = new RestClient<SharedModel.Election>();

            var electionlist = await restclient.GetAsync();

            var results = electionlist.Where(r => r.State.ToLower() == state && r.AreaName.ToLower() == county && r.TypeOfElection.ToLower() == typename);

            return results.ToList();
        }
    }
}
