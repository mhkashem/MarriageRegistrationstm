using MarriageRegistration.Model;
using MarriageRegistration.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MarriageRegistration.WebApi.Controllers
{
    [EnableCorsAttribute("http://localhost:56494", "*", "*")]
    public class LoginController : ApiController
    {
        // GET: api/Login
        [HttpGet]
        public IHttpActionResult KaziLogin(int NID,string Password)
        {
            MarriageRegistrationDBEntities db = new MarriageRegistrationDBEntities();

            int aa = NID;
            string pass = Password;
            var kazi = db.Kazis.SingleOrDefault(m => m.NID == aa && m.Password==pass);
            if (kazi != null)
            {
                var id = kazi.Id;
                return Ok(id);
                //return Ok(kazi);
            }


            return NotFound();
        }

       
      

       
      

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
