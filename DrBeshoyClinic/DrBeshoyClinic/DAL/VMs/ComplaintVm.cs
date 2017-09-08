using System.ComponentModel;

namespace DrBeshoyClinic.DAL.VMs
{
    public class ComplaintVm
    {
        [DisplayName("Complaint Name")]
        public string ComplaintName { get; set; }
    }
}