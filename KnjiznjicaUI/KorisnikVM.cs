using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KnjiznjicaUI
{
    public class KorisnikVM : StringContent
    {
        public string PIN { get; set; }
        public string KorisnickoIme { get; set; }
    }
}
