using System.Collections.Generic;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

namespace DrBeshoyClinic.BLL
{
    public class ComplaintManager : BaseManager
    {
        public void AddListOfComplaints(List<Complaint> complaints)
        {
            complaints.ForEach(complaint => UnitOfWork.ComplaintRepository.Add(complaint));
        }

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

        #endregion
    }
}