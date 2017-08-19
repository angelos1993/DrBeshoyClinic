using System;
using DrBeshoyClinic.Utility;

namespace DrBeshoyClinic.DAL.VMs
{
    public class ListBoxVm
    {
        public DateTime DateTime { get; set; }
        public string DateTimeString => DateTime.ToListBoxDateString();
    }
}