//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ActionFilterDemo.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Reports = new HashSet<Report>();
        }
    
        public int UserID { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Report> Reports { get; set; }
    }
}
