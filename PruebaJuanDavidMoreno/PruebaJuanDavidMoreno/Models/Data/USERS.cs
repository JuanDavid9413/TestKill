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
    
    public partial class USERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USERS()
        {
            this.PARAMETER_ITEMS = new HashSet<PARAMETER_ITEMS>();
        }
    
        public int ID_USER { get; set; }
        public string NAME { get; set; }
        public string LAST_NAME { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public System.DateTime LAST_MODIFICATION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARAMETER_ITEMS> PARAMETER_ITEMS { get; set; }
    }
}
