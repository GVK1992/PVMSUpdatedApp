//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PVMSApp.Models.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class city
    {
        public string city_id { get; set; }
        public string city_name { get; set; }
        public string state_id { get; set; }
    
        public virtual State State { get; set; }
    }
}
