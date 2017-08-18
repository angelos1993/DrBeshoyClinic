using System.ComponentModel;

namespace DrBeshoyClinic.DAL.VMs
{
    public class LabTestVm
    {
        [DisplayName("Lab Test Name")]
        public string TestName { get; set; }

        [DisplayName("Lab Test Result")]
        public string TestResult { get; set; }
    }
}