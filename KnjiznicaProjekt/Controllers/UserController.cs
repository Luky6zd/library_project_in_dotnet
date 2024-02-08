using KnjiznicaProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnjiznicaProjekt.Controllers
{
    public class UserController : ApiController
    {
        //Svi korisnici
        //GET api/user
        [HttpGet]
        public IHttpActionResult GetAllKnjiga()
        {
            List<Korisnik> listaKorisnika = null;

            var ctx = new KnjiznicaEntities();

            listaKorisnika = ctx.Korisnik.ToList();

            if (listaKorisnika.Count == 0)
            {
                return NotFound();
            }

            return Ok(listaKorisnika);
        }

        //Jedan korisnik (po ID-u)
        //GET api/user/{id}
        [HttpGet]
        public IHttpActionResult GetKorisnik(int ID)
        {
            var ctx = new KnjiznicaEntities();

            var user = ctx.Korisnik.Where(lambda => lambda.KorisnikID == ID).SingleOrDefault();

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        //Dodaj novog korisnika
        //POST api/book
        [HttpPost]
        public IHttpActionResult PostKorisnik(Korisnik noviKorisnik)
        {
            using (var ctx = new KnjiznicaEntities())
            {
                ctx.Korisnik.Add(noviKorisnik);

                ctx.SaveChanges();
            }

            return Ok();
        }

        //Update-aj knjigu
        //PUT api/book/ID
        [HttpPut]
        public IHttpActionResult PutKorisnik(Korisnik updateKorisnik)
        {
            using (var ctx = new KnjiznicaEntities())
            {
                var korisnik = ctx.Korisnik.Where(lambda => lambda.KorisnikID == updateKorisnik.KorisnikID).SingleOrDefault();

                if (korisnik == null)
                {
                    return NotFound();
                }

                korisnik = updateKorisnik;

                ctx.SaveChanges();
            }

            return Ok();
        }

        //Obriši korisnika
        //DELETE api/user/ID
        [HttpDelete]
        public IHttpActionResult DeleteKorisnik(int id)
        {
            using (var ctx = new KnjiznicaEntities())
            {
                var korisnik = ctx.Korisnik.Where(lambda => lambda.KorisnikID == id).SingleOrDefault();

                if (korisnik == null)
                {
                    return NotFound();
                }

                ctx.Korisnik.Remove(korisnik);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
