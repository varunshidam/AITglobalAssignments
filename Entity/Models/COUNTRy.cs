//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class COUNTRy
    {
        public string COUNTRY_ID { get; set; }
        public string COUNTRY_NAME { get; set; }
        public Nullable<decimal> REGION_ID { get; set; }
    
        public virtual REGION REGION { get; set; }
    }
}