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
    
    public partial class EMPLOYEE
    {
        public decimal EMPLOYEE_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE_NUMBER { get; set; }
        public System.DateTime HIRE_DATE { get; set; }
        public string JOB_ID { get; set; }
        public Nullable<decimal> SALARY { get; set; }
        public Nullable<decimal> COMMISSION_PCT { get; set; }
        public Nullable<decimal> MANAGER_ID { get; set; }
        public Nullable<decimal> DEPARTMENT_ID { get; set; }
    }
}
