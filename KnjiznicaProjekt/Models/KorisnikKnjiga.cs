//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KnjiznicaProjekt.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KorisnikKnjiga
    {
        public int KorisnikKnjigaID { get; set; }
        public int KorisnikID { get; set; }
        public int KnjigaID { get; set; }
        public System.DateTime DatumPosudbe { get; set; }
        public int BrojDana { get; set; }
    
        public virtual Knjiga Knjiga { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
