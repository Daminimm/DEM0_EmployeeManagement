//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employeeinfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employeeinfo()
        {
            this.Attendances = new HashSet<Attendance>();
        }
    
        public int EmployeeId { get; set; }
        public int UserId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual Userlogin Userlogin { get; set; }
    }
}