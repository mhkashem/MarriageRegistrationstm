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

    public class MarriageRegistersController : ApiController
    {
        // GET: api/MarriageRegisters
        public IEnumerable<string> Get()
        {


            return new string[] { "value1", "value2" };
        }

        // GET: api/MarriageRegisters/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MarriageRegisters
        public IHttpActionResult Post([FromBody]MarrigeRegisterView value)
        {
            MarriageRegistrationDBEntities db = new MarriageRegistrationDBEntities();

            var witnes = new Witness();

            witnes.Witness1 = value.Witness1Name;
            witnes.Witness2 = value.Witness2Name;
            witnes.Witness3 = value.Witness3Name;
            db.Witnesses.Add(witnes);
            //db.SaveChanges();

            var attorney = new Attorney();

            attorney.BrideAttorneyName = value.BridegroomAttorneyName;
            attorney.BridegroomAttorneyNID = value.BridegroomAttorneyNID;
            attorney.BrideAttorneyName = value.BrideAttorneyName;
            attorney.BrideAttorneyNID = value.BrideAttorneyNID;
            db.Attorneys.Add(attorney);
            //db.SaveChanges();
            var ff = Guid.NewGuid().ToString();
            var now = DateTime.Now;
            var year = now.Year;
            var month = now.Month.ToString("00");
            var date = now.Day.ToString("00");
            var fomat = year+month+date;
            var maxId = 0;
            if (db.MarriageRegisters.Any(m => m.MarriageRegiNo.StartsWith(fomat)))
            {
                 maxId = db.MarriageRegisters
                .Where(m => m.MarriageRegiNo.StartsWith(fomat))
                .Select(m => m.MarriageRegiNo.Substring(fomat.Length))
                .Select(int.Parse)
                .Max()                         
                + 1;
            }
            
            var id = fomat + (maxId.ToString().PadLeft(5, '0'));

            var marriageRegister = new MarriageRegister();
            marriageRegister.BrideName = value.BrideName;
            marriageRegister.BrideNID = value.BrideNID;
            marriageRegister.BridegroomName = value.BridegroomName;
            marriageRegister.BridegroomNID = value.BridegroomNID;
            marriageRegister.MarriageRegiNo = id;
            marriageRegister.Mohor = value.Mohor;
            marriageRegister.Moajjal = value.Moajjal;
            marriageRegister.NonMoajjal = value.NonMoajjal;
            marriageRegister.NikhaReaderName = value.NikhaReaderName;
            marriageRegister.NikhaReaderNameNID = value.NikhaReaderNameNID;
            marriageRegister.WitnessId = witnes.Id;
            marriageRegister.AttorneyId = attorney.Id;
            marriageRegister.kaziId = value.KaziId;
            marriageRegister.Date = DateTime.Now;
            marriageRegister.PaidAmount = value.PaidAmount;
            db.MarriageRegisters.Add(marriageRegister);


            db.SaveChanges();

            return Ok(marriageRegister.MarriageRegiNo);
        }



        // PUT: api/MarriageRegisters/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MarriageRegisters/5
        public void Delete(int id)
        {
        }
    }
}
