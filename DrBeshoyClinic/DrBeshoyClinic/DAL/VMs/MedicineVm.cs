using System.ComponentModel;

namespace DrBeshoyClinic.DAL.VMs
{
    public class MedicineVm
    {
        [DisplayName("Medicine Name")]
        public string TreatmentName { get; set; }

        [DisplayName("Medicine Period")]
        public string Period { get; set; }

        [DisplayName("Medicine Description")]
        public string Description { get; set; }
    }
}