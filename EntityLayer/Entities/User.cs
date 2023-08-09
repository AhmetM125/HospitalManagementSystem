//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Appointments = new HashSet<Appointment>();
        }
    
        public int UserId { get; set; }
        public string User_Name { get; set; }
        public string User_Surname { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public Nullable<int> UserDepartmentId { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserMail { get; set; }
        public Nullable<int> UserDutyId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual Department Department { get; set; }
        public virtual Duty Duty { get; set; }
    }
}