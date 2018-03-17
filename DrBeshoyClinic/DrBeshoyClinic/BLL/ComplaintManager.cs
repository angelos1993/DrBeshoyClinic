using System;
using System.Collections.Generic;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.Utility;

namespace DrBeshoyClinic.BLL
{
    public class ComplaintManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public IQueryable<Complaint> GetAllComplaints()
        {
            return UnitOfWork.ComplaintRepository.GetAll();
        }

        public IQueryable<Complaint> GetComplaintsForPatient(string patientId)
        {
            return UnitOfWork.ComplaintRepository.Get(complaint => complaint.PatientId == patientId);
        }

        public string GetComplaintsStringByPatientAndDate(string patientId, DateTime date)
        {
            return GetComplaintsForPatient(patientId).Where(complaint => complaint.Date == date)
                .Select(complaint => complaint.Name).ToCommaSeperatedString();
        }

        public void AddListOfComplaints(List<Complaint> complaints)
        {
            complaints.ForEach(complaint => UnitOfWork.ComplaintRepository.Add(complaint));
        }

        public void DeleteListOfComplaints(List<Complaint> complaints)
        {
            complaints.ForEach(complaint => UnitOfWork.ComplaintRepository.Delete(complaint));
        }

        #endregion
    }
}