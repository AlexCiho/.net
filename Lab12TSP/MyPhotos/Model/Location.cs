//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotos.Model
{
    using System;
    using System.Collections.Generic;

    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            this.Name = "";
            this.Scenery = "";
            this.ZipCode = "";
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Scenery { get; set; }
        public string ZipCode { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public int MultimediaId { get; set; }
    
        public virtual Multimedia Multimedia { get; set; }
    }
}