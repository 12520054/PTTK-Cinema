//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FILM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Poster { get; set; }
        public int Duration { get; set; }
        public string Director { get; set; }
        public string Actor { get; set; }
        public System.DateTime ProductionYear { get; set; }
        public string ProductionCountry { get; set; }
        public int FilmCategory { get; set; }
        public string Description { get; set; }
        public string Screenshot { get; set; }
        public string Trailer { get; set; }
    
        public virtual FILMCATEGORY FILMCATEGORY1 { get; set; }
    }
}
