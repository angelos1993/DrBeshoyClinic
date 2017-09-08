using System;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.Utility;

namespace DrBeshoyClinic.BLL
{
    public class SurgicalHxManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public IQueryable<SurgicalHx> GetSurgicalHxesForPatient(string patientId)
        {
            return UnitOfWork.SurgicalHxRepository.Get(surgicalHx => surgicalHx.PatientId == patientId);
        }

        public void AddOrUpdateSurgicalHx(SurgicalHx surgicalHx)
        {
            if (!IsExistSurgicalHx(surgicalHx.PatientId, surgicalHx.Date))
                UnitOfWork.SurgicalHxRepository.Add(surgicalHx);
            else
                UnitOfWork.SurgicalHxRepository.Update(surgicalHx);
        }

        public bool IsExistSurgicalHx(string patientId, DateTime date)
        {
            return UnitOfWork.SurgicalHxRepository
                .Get(surgicalHx => surgicalHx.PatientId == patientId && surgicalHx.Date == date).Any();
        }

        public string GetSurgicalHxsForPatientByDate(string patientId, DateTime date)
        {
            return GetSurgicalHxesForPatient(patientId).Where(surgicalHx => surgicalHx.Date == date)
                .Select(surgicalHx => surgicalHx.Description).ToCommaSeperatedString();
        }

        #endregion
    }
}