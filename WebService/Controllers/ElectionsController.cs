using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebService.Models;

namespace WebService.Controllers
{
    public class ElectionsController : ApiController
    {
        private electionEntities db = new electionEntities();
        
        // GET: api/Elections
        public IQueryable<Election> GetElections()
        {
            return db.Elections;
        }
        
        // GET: api/Elections/5
        [ResponseType(typeof(Election))]
        public IHttpActionResult GetElection(int id)
        {
            Election election = db.Elections.Find(id);
            if (election == null)
            {
                return NotFound();
            }

            return Ok(election);
        }
    }
}