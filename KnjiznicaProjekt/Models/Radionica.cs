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
    
    public partial class Radionica
    {
        public Radionica()
        {
            this.KorisnikRadionica = new HashSet<KorisnikRadionica>();
        }
    
        public int RadionicaID { get; set; }
        public string Naziv { get; set; }
        public int BrojClanova { get; set; }
        public int Trajanje { get; set; }
        public System.DateTime DatumPocetka { get; set; }
        public int BrojSati { get; set; }
        public bool Ponedjeljak { get; set; }
        public bool Utorak { get; set; }
        public bool Srijeda { get; set; }
        public bool Cetvrtak { get; set; }
        public bool Petak { get; set; }
    
        public virtual ICollection<KorisnikRadionica> KorisnikRadionica { get; set; }
    }
}
