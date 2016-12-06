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
        
    }

}
