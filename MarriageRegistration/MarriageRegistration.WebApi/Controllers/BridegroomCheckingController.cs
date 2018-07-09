using MarriageRegistration.Model;
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
    public class BridegroomCheckingController : ApiController
    {
        MarriageRegistrationDBEntities db = new MarriageRegistrationDBEntities();
        // GET: api/BridegroomChecking
        public IHttpActionResult GetBridegroomInfoes(string searchText)
        {
            try
            {
                NationalID bridegroom = db.NationalIDs.SingleOrDefault(m => m.NID == searchText);
                if (bridegroom.Gender == "Male")
                {
                    DateTime bd = Convert.ToDateTime(bridegroom.Birthday);
                    DateTime now = DateTime.Today;
                    int age = now.Year - bd.Year;
                    if (now < bd.AddYears(age))
                        age--;
                    if (age >= 22)
                    {
                        var brid = db.NationalIDs.Where(m => m.NID.Contains(searchText));
                        return Ok(brid);
                    }
                    else
                    {

                        return NotFound();
                    }
                }
                else
                {

                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        // GET: api/BridegroomChecking/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BridegroomChecking
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BridegroomChecking/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BridegroomChecking/5
        public void Delete(int id)
        {
        }
    }
}
