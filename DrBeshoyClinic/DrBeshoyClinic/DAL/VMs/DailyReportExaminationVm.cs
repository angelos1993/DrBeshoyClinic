using System.ComponentModel;

namespace DrBeshoyClinic.DAL.VMs
{
    public class DailyReportExaminationVm
    {
        [DisplayName("اسم المريض")]
        public string PatientName { get; set; }
        [DisplayName("نوع الكشف")]
        public string ExaminationType { get; set; }
    }
}