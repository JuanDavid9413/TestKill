//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaJuanDavidMoreno.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PARAMETER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PARAMETER()
        {
            this.PARAMETER_ITEMS = new HashSet<PARAMETER_ITEMS>();
        }
    
        public int ID_PARAMETER { get; set; }
        public string CODE { get; set; }
        public string NAME_PRODUCTO { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public System.DateTime LAST_MODIFICATION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARAMETER_ITEMS> PARAMETER_ITEMS { get; set; }
    }
}