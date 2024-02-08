using KnjiznicaProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace KnjiznicaProjekt.Controllers
{
    public class BookController : ApiController
    {
        //Sve knjige
        //GET api/book
        [HttpGet]
        public IHttpActionResult GetAllKnjiga()
        {
            List<Knjiga> listaKnjiga = null;

            var ctx = new KnjiznicaEntities();

            listaKnjiga = ctx.Knjiga.ToList();

            if(listaKnjiga.Count == 0)
            {
                return NotFound();
            }

            return Ok(listaKnjiga);
        }

        //Jedna knjiga (po ID-u)
        //GET api/book/{id}
        [HttpGet]
        public IHttpActionResult GetKnjiga(int ID)
        {
            var ctx = new KnjiznicaEntities();

            var book = ctx.Knjiga.Where(lambda => lambda.KnjigaID == ID).SingleOrDefault();

            if(book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        //Dodaj novu knjigu
        //POST api/book
        [HttpPost]
        public IHttpActionResult PostKnjiga(Knjiga novaKnjiga)
        {
            using (var ctx = new KnjiznicaEntities())
            {
                ctx.Knjiga.Add(novaKnjiga);

                ctx.SaveChanges();
            }

            return Ok();
        }

        //Update-aj knjigu
        //PUT api/book/ID
        [HttpPut]
        public IHttpActionResult PutKnjiga(Knjiga updateKnjiga)
        {
            using (var ctx = new KnjiznicaEntities())
            {
                var knjiga = ctx.Knjiga.Where(lambda => lambda.KnjigaID == updateKnjiga.KnjigaID).SingleOrDefault();

                if (knjiga == null)
                {
                    return NotFound();
                }

                knjiga = updateKnjiga;

                ctx.SaveChanges();
            }

            return Ok();
        }

        //Obriši knjigu
        //DELETE api/book/ID
        [HttpDelete]
        public IHttpActionResult DeleteKnjiga(int id)
        {
            using (var ctx = new KnjiznicaEntities())
            {
                var knjiga = ctx.Knjiga.Where(lambda => lambda.KnjigaID == id).SingleOrDefault();

                if (knjiga == null)
                {
                    return NotFound();
                }

                ctx.Knjiga.Remove(knjiga);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}