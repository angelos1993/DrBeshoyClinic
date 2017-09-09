using System;
using System.Collections.Generic;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.Utility;
using static DrBeshoyClinic.Utility.Constants;

namespace DrBeshoyClinic.DAL.VMs
{
    public class RoshettaVm
    {
        public string PatientName { get; set; }
        public DateTime? PatientBirthDate { get; set; }
        private string _diagnosis;

        public string Diagnosis
        {
            get => !_diagnosis.IsNullOrEmptyOrWhiteSpace() ? _diagnosis : ReportParameterEmptyValue;
            set => _diagnosis = value;
        }

        public DateTime Date { get; set; }
        public List<RoshettaMedicineVm> MedicineDetails { get; set; }
        public string DateString => Date.ToShortDateString();

        public string PatientAge
        {
            get
            {
                if (!PatientBirthDate.HasValue)
                    return ReportParameterEmptyValue;
                var age = Date.Year - PatientBirthDate.Value.Year;
                if (PatientBirthDate > Date.AddYears(-age))
                    age--;
                return age.ToString();
            }
        }
    }
}