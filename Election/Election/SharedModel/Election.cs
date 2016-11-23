using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Election.SharedModel
{

    public class Election
    {
        public int Id { get; set; }

        public string TypeOfElection { get; set; }

        public string State { get; set; }

        public string Date { get; set; }

        public string AreaName { get; set; }

        public string AreaType { get; set; }

        public int? TotalVotes { get; set; }

        public int? RepublicanVotes { get; set; }

        public string RepublicanCand { get; set; }

        public int? DemocraticVotes { get; set; }

        public string DemocraticCand { get; set; }

        public string ThirdParty { get; set; }

        public int? ThirdPartyVotes { get; set; }

        public string ThirdPartyCand { get; set; }

        public int? OtherVotes { get; set; }

        /*
         * Utility method to handle cases where non integer, N/A was used to represent counties where votes are not available.
         */
        private static int ToInt(string v)
        {
            int a;
            int.TryParse(v, out a);
            return a;
        }

        public static List<KeyValuePair<string, int?>> OrderByVotes(Election election)
        {
            var votesArray = new List<KeyValuePair<string, int?>>()
            {
                new KeyValuePair<string, int?>(election.DemocraticCand, election.DemocraticVotes),
                new KeyValuePair<string, int?>(election.RepublicanCand, election.RepublicanVotes),
                new KeyValuePair<string, int?>(election.ThirdPartyCand, election.ThirdPartyVotes),
                new KeyValuePair<string, int?>("Other Candidates", election.OtherVotes)
            };

            var result = votesArray.OrderByDescending(key => key.Value);

            return result.ToList();
        }

        public Election()
        { }

    }

}
