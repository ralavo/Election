using System;

namespace Election.SharedModel
{
  
    /* This class define the properties of a Election object
     */
    public class Election
    {
        public int ID { get; set; }
        public string TypeOfElection { get; set; }
        public string State { get; set; }
        public int Date { get; set; }
        public string AreaName { get; set; }
        public string AreaType { get; set; }
        public int TotalVotes { get; set; }
        public int RepublicanVotes { get; set; }
        public string RepublicanCand { get; set; }
        public int DemocraticVotes { get; set; }
        public string DemocraticCand { get; set; }
        public string ThirdParty { get; set; }
        public string ThirdPartyVotes { get; set; }
        public string ThirdPartyCand { get; set; }
        public int OtherVotes { get; set; }
    }

}
