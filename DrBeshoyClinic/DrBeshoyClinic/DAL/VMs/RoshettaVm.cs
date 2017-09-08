using System;
using DrBeshoyClinic.DAL.Model;
using static DrBeshoyClinic.Utility.Constants;

namespace DrBeshoyClinic.DAL.VMs
{
    public class RoshettaVm
    {
        public string PatientName { get; set; }
        public DateTime? PatientBirthDate { get; set; }
        public string Diagnosis { get; set; }
        public Medicine Medicine { get; set; }
        public string DateString => Medicine.Date.ToShortDateString();

        public string PatientAge
        {
            get
            {
                if (!PatientBirthDate.HasValue)
                    return ReportParameterEmptyValue;
                var age = Medicine.Date.Year - PatientBirthDate.Value.Year;
                if (PatientBirthDate > Medicine.Date.AddYears(-age))
                    age--;
                return age.ToString();
            }
        }
    }
}