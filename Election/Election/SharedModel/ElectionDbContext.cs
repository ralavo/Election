/*
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Election.SharedModel
{
    public class ElectionDbContext : DbContext
    {
        public ElectionDbContext() : base("DefaultConnection")
        {
        }
        /*
        public DbSet<Election> Elections { get; set; }

        public List<Election> GetResultsForCounty(string county, string typename)
        {
            var results = Elections.Where(r => r.AreaName == county && r.TypeOfElection == typename);

            return results.ToList();
        }
    }
}
*/