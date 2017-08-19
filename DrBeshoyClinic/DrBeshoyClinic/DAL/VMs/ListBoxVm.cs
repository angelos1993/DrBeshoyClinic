using System;
using DrBeshoyClinic.Utility;

namespace DrBeshoyClinic.DAL.VMs
{
    public class ListBoxVm
    {
        public DateTime Date { get; set; }
        public string DateString => Date.ToListBoxDateString();
    }
}