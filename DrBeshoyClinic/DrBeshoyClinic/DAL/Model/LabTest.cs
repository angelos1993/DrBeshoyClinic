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
    
    public partial class LabTest
    {
        public int Id { get; set; }
        public string TestName { get; set; }
        public string TestResult { get; set; }
        public System.DateTime Date { get; set; }
        public string PatientId { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
