//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taixevaxe
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChuXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuXe()
        {
            this.XEs = new HashSet<XE>();
        }
    
        public string MaChuXe { get; set; }
        public string HoTen { get; set; }
        public string MatKhau { get; set; }
        public int CMT { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XE> XEs { get; set; }
    }
}