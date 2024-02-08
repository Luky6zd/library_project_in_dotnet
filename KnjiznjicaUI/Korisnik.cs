using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnjiznjicaUI
{
    public class Korisnik
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }
        public string Adresa { get; set; }
        public System.DateTime DatumRodenja { get; set; }
        public string Email { get; set; }
        public string Spol { get; set; }
        public string StatusKorisnika { get; set; }
        public int BrojKnjiga { get; set; }
        public string BrojTelefona { get; set; }
        public int BrojIskaznice { get; set; }
        public string PIN { get; set; }
        public string KorisnickoIme { get; set; }
    }
}
