using System.ComponentModel;

namespace DrBeshoyClinic.DAL.VMs
{
    public class RadiologyVm
    {
        [DisplayName("Radiology Name")]
        public string Name { get; set; }

        [DisplayName("Radiology Description")]
        public string Description { get; set; }
    }
}