using System;
using System.Linq;
using DrBeshoyClinic.BLL.Infrastructure;
using DrBeshoyClinic.DAL.Model;

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
                .Get(hx => hx.PatientId == patientId && hx.Date == date).Any();
        }

        #endregion
    }
}