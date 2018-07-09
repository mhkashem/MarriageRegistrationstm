using MarriageRegistration.Model;
using MarriageRegistration.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MarriageRegistration.WebApi.Controllers
{
    [EnableCorsAttribute("http://localhost:56494", "*", "*")]
    public class MaritalStatusController : ApiController
    {
        MarriageRegistrationDBEntities db = new MarriageRegistrationDBEntities();

        // GET: api/MaritalStatus
        [HttpGet]
        public IHttpActionResult MaritalStatusCheck(string regi_no)
        {
            var status = db.MarriageRegisters
                .Where(m => m.MarriageRegiNo == regi_no)
                 .Select(mr => new MarrigeRegisterView
                 {
                     BridegroomName = mr.BridegroomName,
                     BridegroomNID = mr.BridegroomNID,
                     BrideName = mr.BrideName,
                     BrideNID = mr.BrideNID
                   


        }).SingleOrDefault();
            if (status != null)
            {
                return Ok(status);
            }
            return NotFound();
        }

        // GET: api/MaritalStatus/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MaritalStatus
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MaritalStatus/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MaritalStatus/5
        public void Delete(int id)
        {
        }
    }
}
