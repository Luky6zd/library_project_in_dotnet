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
    
    public partial class Clan
    {
        public int KorisnikId { get; set; }
        public string Status { get; set; }
        public System.DateTime DatumUclanjivanja { get; set; }
        public System.DateTime DatumIsteka { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
    }
}