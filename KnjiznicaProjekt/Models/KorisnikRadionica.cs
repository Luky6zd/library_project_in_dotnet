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
    
    public partial class KorisnikRadionica
    {
        public int KorisnikRadionicaID { get; set; }
        public int KorisnikID { get; set; }
        public int RadionicaID { get; set; }
    
        public virtual Radionica Radionica { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}