//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusAndModel.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiaDiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiaDiem()
        {
            this.CTTours = new HashSet<CTTour>();
        }
    
        public int Id { get; set; }
        public string TenDiaDiem { get; set; }
        public int TinhThanhId { get; set; }
    
        public virtual TinhThanh TinhThanh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTTour> CTTours { get; set; }
    }
}
