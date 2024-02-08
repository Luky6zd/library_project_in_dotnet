using KnjiznicaProjekt.ViewModels;
using KnjiznicaProjekt.Models;
using System.Linq;
using System.Web.Http;

namespace KnjiznicaProjekt.Controllers
{
    public class LoginController : ApiController
    {
        //Korisnički login
        //POST api/login
        [HttpPost]
        public IHttpActionResult GetLogin(KorisnikVM login)
        {
            var ctx = new KnjiznicaEntities();

            var korisnik = ctx.Korisnik.Where(lambda => lambda.KorisnickoIme == login.KorisnickoIme && lambda.PIN == login.PIN).SingleOrDefault();

            if (korisnik == null)
            {
                return NotFound();
            }

            return Ok(korisnik.KorisnikID);
        }
    }
}
