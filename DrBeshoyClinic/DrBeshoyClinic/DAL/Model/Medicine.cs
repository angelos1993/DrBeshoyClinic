//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrBeshoyClinic.DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medicine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicine()
        {
            this.MedicineDetails = new HashSet<MedicineDetail>();
        }
    
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public string PatientId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicineDetail> MedicineDetails { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
