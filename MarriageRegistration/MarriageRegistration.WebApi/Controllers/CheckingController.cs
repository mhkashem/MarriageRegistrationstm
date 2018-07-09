using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using MarriageRegistration.Model;
using MarriageRegistration.ViewModel;
namespace MarriageRegistration.WebApi.Controllers
{
    [EnableCorsAttribute("http://localhost:56494", "*", "*")]

    public class CheckingController : ApiController
    {
        MarriageRegistrationDBEntities db = new MarriageRegistrationDBEntities();
        [HttpGet]
        public IHttpActionResult  GetBrideInfoes(string searchText)
        {
            try
            {
                NationalID bride = db.NationalIDs.SingleOrDefault(m => m.NID == searchText);
                if (bride.Gender == "Female")
                {
                    DateTime bd = Convert.ToDateTime(bride.Birthday);
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

        


    }
}
